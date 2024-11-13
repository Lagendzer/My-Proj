#include <pch.h>
#include "DLLGame.h"

#include "Windows.h"

#include <iostream>
#include <algorithm> // Для использования алгоритмов STL
#include <string>
#include <Objbase.h>
#include <strsafe.h>
#include <fstream>
#include <set>
#include <map>
#include <numeric> // для accumulate
#include <codecvt>
#include <vector> // Для использования vector
#include <chrono> // Для работы с временем

const int WIDTH = 800;
const int HEIGHT = 600;
const int PLAYER_SIZE = 20;
const int ENEMY_SIZE = 20;
const int BULLET_SIZE = 5;
const int OBSTACLE_SIZE = 40;
const int MOVE_SPEED = 5;
const int BULLET_SPEED = 10;
const int ENEMY_SPEED = 3;
const int BOSS_SIZE = 40;
const int BOSS_SHOOT_DELAY = 1000;

using namespace std;

vector<Entity*> entities; // использование vector вместо глобального массива
map<int, Entity*> entityMap;

// Добавляем функцию сравнения для сортировки объектов Entity по координате X
bool compareEntitiesByX(const Entity* e1, const Entity* e2) {
    return e1->getPosition().x < e2->getPosition().x;
}

void sortEntitiesByX() {
    sort(entities.begin(), entities.end(), compareEntitiesByX);
}

// Класс для поиска объекта в векторе entities по типу ENTITY_TYPE
class FindEntityType {
    EntityType m_type;
public:
    FindEntityType(EntityType type) : m_type(type) {}
    bool operator()(const Entity* entity) {
        return entity->getType() == m_type;
    }
};

Entity* findEntityByType(EntityType type) {
    auto it = find_if(entities.begin(), entities.end(), FindEntityType(type));
    return (it != entities.end()) ? *it : nullptr;
}

vector<int> getEntitiesSizes() {
    vector<int> sizes(entities.size());
    transform(entities.begin(), entities.end(), sizes.begin(), [](const Entity* entity) {
        return entity->getSize();
        });
    return sizes;
}

Entity::Entity(int x, int y, int _size, COLORREF _color, EntityType _type) : position(Point(x, y)), size(_size), color(_color), type(_type), destroyed(false) {}

Entity::~Entity() {}

Point Entity::getPosition() const {
    if (this) {
        return position;
    }
    else {
        // Обработка случая, когда this является нулевым указателем
        // Например, возвращение некорректной точки или генерация исключения
        // В зависимости от требований вашего приложения
        return Point(0, 0); // Возвращаем начальную точку (0, 0) как запасной вариант
    }
}

vector<Entity*> performIntersection(const vector<Entity*>& entities1, const vector<Entity*>& entities2) {
    vector<Entity*> result;
    // Сначала сортируем оба вектора, так как set_intersection требует, чтобы входные последовательности были упорядочены
    vector<Entity*> sortedEntities1(entities1.begin(), entities1.end());
    vector<Entity*> sortedEntities2(entities2.begin(), entities2.end());
    sort(sortedEntities1.begin(), sortedEntities1.end(), compareEntitiesByX);
    sort(sortedEntities2.begin(), sortedEntities2.end(), compareEntitiesByX);
    // Выполняем операцию пересечения
    set_intersection(sortedEntities1.begin(), sortedEntities1.end(), sortedEntities2.begin(), sortedEntities2.end(), back_inserter(result), compareEntitiesByX);
    return result;
}

int Entity::getSize() const {
    return size;
}

EntityType Entity::getType() const {
    return type;
}

RECT Entity::getBoundingBox() const {
    RECT rect = { position.x, position.y, position.x + size, position.y + size };
    return rect;
}

bool Entity::isDestroyed() const {
    return destroyed;
}

void Entity::setDestroyed(bool value) {
    destroyed = value;
    if (destroyed) {
        cout << "Entity destroyed" << endl;
    }
    else {
        cout << "Entity restored" << endl;
    }
}


bool checkCollision(const Entity& e1, const Entity& e2) {
    RECT rect1 = e1.getBoundingBox();
    RECT rect2 = e2.getBoundingBox();
    return (rect1.left < rect2.right && rect1.right > rect2.left &&
        rect1.top < rect2.bottom && rect1.bottom > rect2.top);
}

Bullet::Bullet(int startX, int startY, int targetX, int targetY) : Entity(startX, startY, BULLET_SIZE, RGB(255, 255, 0), BULLET) {
    double angle = atan2(targetY - startY, targetX - startX);
    velocityX = BULLET_SPEED * cos(angle);
    velocityY = BULLET_SPEED * sin(angle);
}

void Bullet::update() {
    position.x += static_cast<int>(velocityX);
    position.y += static_cast<int>(velocityY);
}

void Bullet::draw(HDC hdc) {
    HBRUSH hBrush = CreateSolidBrush(color);
    SelectObject(hdc, hBrush);
    Ellipse(hdc, position.x, position.y, position.x + size, position.y + size);
    DeleteObject(hBrush);
}

Bullet::~Bullet() {
    for (auto bulletIter = entities.begin(); bulletIter != entities.end(); ++bulletIter) {
        if ((*bulletIter)->getType() == BULLET) {
            Bullet* bullet = dynamic_cast<Bullet*>(*bulletIter);
            // Освобождаем память для пули
            delete bullet;
        }
    }

}

Obstacle::Obstacle(int x, int y) : Entity(x, y, OBSTACLE_SIZE, RGB(255, 0, 0), OBSTACLE) {}

void Obstacle::update() {}

void Obstacle::draw(HDC hdc) {
    HBRUSH hBrush = CreateSolidBrush(color);
    SelectObject(hdc, hBrush);
    Rectangle(hdc, position.x, position.y, position.x + size, position.y + size);
    DeleteObject(hBrush);
}

Obstacle::~Obstacle() {

}

vector<Entity*> findEntitiesByXRange(int minX, int maxX) {
    // Сортируем entities по X, если это необходимо
    sortEntitiesByX();
    // Ищем диапазон объектов с помощью equal_range
    auto range = equal_range(entities.begin(), entities.end(), nullptr, [minX](const Entity* e1, const Entity* e2) {
        return e1->getPosition().x < minX;
        });

    vector<Entity*> result;
    for (auto it = range.first; it != range.second; ++it) {
        if ((*it)->getPosition().x <= maxX) {
            result.push_back(*it);
        }
    }
    return result;
}

Player::Player(int x, int y) : Entity(x, y, PLAYER_SIZE, RGB(0, 255, 0), PLAYER), playerMovingUp(false), playerMovingDown(false), playerMovingLeft(false), playerMovingRight(false), health(10) {}

void Player::update() {
    // Проверяем и обрабатываем движение игрока
    if (playerMovingUp && position.y > 0)
        position.y -= MOVE_SPEED;
    if (playerMovingDown && position.y < HEIGHT - size)
        position.y += MOVE_SPEED;
    if (playerMovingLeft && position.x > 0)
        position.x -= MOVE_SPEED;
    if (playerMovingRight && position.x < WIDTH - size)
        position.x += MOVE_SPEED;
    // Проверяем и обрабатываем столкновения с препятствиями
    auto obstaclesInRange = findEntitiesByXRange(position.x - size, position.x + size);
    for (auto obstacle : obstaclesInRange) {
        if (obstacle->getType() == OBSTACLE) {
            // Проверяем столкновение с препятствием
            if (checkCollision(*this, *obstacle)) {
                // Обрабатываем столкновение с препятствием
                position.x = max(obstacle->getPosition().x - size, 0);
                position.y = max(obstacle->getPosition().y - size, 0);
            }
        }
    }

    // Проверяем и обрабатываем столкновения с врагами и боссом
    for (auto entity : entities) {
        if (entity != this && (entity->getType() == ENEMY || entity->getType() == BOSS)) {
            if (checkCollision(*this, *entity)) {
                // Уменьшаем здоровье игрока
                health--;
                if (health <= 0) {
                    // Действия при завершении игры
                    PostQuitMessage(0); // Завершаем игру
                }
            }
        }
    }
}

void Player::draw(HDC hdc) {
    HBRUSH hBrush = CreateSolidBrush(color);
    SelectObject(hdc, hBrush);
    Rectangle(hdc, position.x, position.y, position.x + size, position.y + size);
    DeleteObject(hBrush);
    // Draw health
    stringstream ss;
    ss << "Health: " << health;
    string healthText = ss.str();
    TextOutA(hdc, 10, 10, healthText.c_str(), healthText.length());
}

Player::~Player() {

}

int Player::getHealth() const {
    return health;
}

Enemy::Enemy(int x, int y) : Entity(x, y, ENEMY_SIZE, RGB(0, 0, 255), ENEMY), health(3) {}

void Enemy::update() {
    for (auto entity : entities) {
        if (entity->getType() == PLAYER) {
            int deltaX = entity->getPosition().x - position.x;
            int deltaY = entity->getPosition().y - position.y;
            double distance = sqrt(deltaX * deltaX + deltaY * deltaY);
            double angle = atan2(deltaY, deltaX);
            position.x += static_cast<int>(cos(angle) * ENEMY_SPEED);
            position.y += static_cast<int>(sin(angle) * ENEMY_SPEED);
        }
    }
}

void Enemy::draw(HDC hdc) {
    HBRUSH hBrush = CreateSolidBrush(color);
    SelectObject(hdc, hBrush);
    Rectangle(hdc, position.x, position.y, position.x + size, position.y + size);
    DeleteObject(hBrush);
}

Enemy::~Enemy() {

}

int Enemy::getHealth() const {
    return health;
}

void Enemy::takeDamage() {
    health--;
    if (health <= 0) {
        this->setDestroyed(true);
        // activeEnemies--;
    }
}

Boss::Boss(int x, int y) : Entity(x, y, BOSS_SIZE, RGB(255, 0, 0), BOSS), health(15) {
    lastShootTime = chrono::steady_clock::now();
}

void Boss::update() {
    for (auto entity : entities) {
        if (entity->getType() == PLAYER) {
            int deltaX = entity->getPosition().x - position.x;
            int deltaY = entity->getPosition().y - position.y;
            double distance = sqrt(deltaX * deltaX + deltaY * deltaY);
            double angle = atan2(deltaY, deltaX);
            position.x += static_cast<int>(cos(angle) * ENEMY_SPEED);
            position.y += static_cast<int>(sin(angle) * ENEMY_SPEED);
        }
    }

    auto now = chrono::steady_clock::now();
    auto elapsedTime = chrono::duration_cast<chrono::milliseconds>(now - lastShootTime).count();

    if (elapsedTime >= BOSS_SHOOT_DELAY) {
        Point playerPos(0, 0);
        for (auto entity : entities) {
            if (entity->getType() == PLAYER) {
                playerPos = entity->getPosition();
                break;
            }
        }
        entities.push_back(new Bullet(position.x + BOSS_SIZE / 2, position.y + BOSS_SIZE / 2, playerPos.x, playerPos.y));
        lastShootTime = now;
    }
}

void Boss::draw(HDC hdc) {
    HBRUSH hBrush = CreateSolidBrush(color);
    SelectObject(hdc, hBrush);
    Rectangle(hdc, position.x, position.y, position.x + size, position.y + size);
    DeleteObject(hBrush);
}

Boss::~Boss() {

}

void Boss::takeDamage() {
    health--;
    if (health <= 0) {
        // Set game over flag or handle game over event
        PostQuitMessage(0); // Завершаем игру
        this->setDestroyed(true);
    }
}
