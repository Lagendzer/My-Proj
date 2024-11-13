#pragma once

#ifndef DLL_EXPORTS
#define DLL_API __declspec(dllexport)  
#else
#define DLL_API __declspec(dllimport)
#endif

#include <windows.h>
#include <vector>
#include <cmath>
#include <random>
#include <chrono>
#include <sstream>

using namespace std;

// Переменные activeEnemies и bossSpawned должны быть определены в одном cpp-файле.
extern int activeEnemies;
extern bool bossSpawned;

// Определяем класс Leaks для автоматического вызова _CrtDumpMemoryLeaks()
struct Leaks {
    ~Leaks() {
        _CrtDumpMemoryLeaks();
    }
};
extern Leaks _l;

// Определяем структуру Point для хранения координат точки
struct DLL_API Point {
    int x, y;
    Point(int _x, int _y) : x(_x), y(_y) {}
};

// Перечисление EntityType для определения типа сущности
enum DLL_API EntityType {
    PLAYER,
    ENEMY,
    BULLET,
    OBSTACLE,
    BOSS
};

// Определяем класс Entity
class DLL_API Entity {
protected:
    Point position;
    int size;
    COLORREF color;
    EntityType type;
    bool destroyed;
public:
    Entity(int x, int y, int _size, COLORREF _color, EntityType _type);
    virtual ~Entity();
    virtual void update() = 0;
    virtual void draw(HDC hdc) = 0;
    Point getPosition() const;
    int getSize() const;
    EntityType getType() const;
    RECT getBoundingBox() const;
    bool isDestroyed() const;
    void setDestroyed(bool value);
};

// Функция checkCollision для проверки коллизии между двумя сущностями
DLL_API bool checkCollision(const Entity& e1, const Entity& e2);

// Определяем класс Bullet
class DLL_API Bullet : public Entity {
    float velocityX;
    float velocityY;
public:
    Bullet(int startX, int startY, int targetX, int targetY);
    virtual ~Bullet(); // Добавляем деструктор
    void update() override;
    void draw(HDC hdc) override;
};

// Определяем класс Obstacle
class DLL_API Obstacle : public Entity {
public:
    Obstacle(int x, int y);
    virtual ~Obstacle(); // Добавляем деструктор
    void update() override;
    void draw(HDC hdc) override;
};

// Определяем класс Player
class DLL_API Player : public Entity {
private:
    int health;
public:
    bool playerMovingUp;
    bool playerMovingDown;
    bool playerMovingLeft;
    bool playerMovingRight;
    Player(int x, int y);
    virtual ~Player(); // Добавляем деструктор
    void update() override;
    void draw(HDC hdc) override;
    int getHealth() const;
};

// Определяем класс Enemy
class DLL_API Enemy : public Entity {
private:
    int health;
public:
    Enemy(int x, int y);
    virtual ~Enemy(); // Добавляем деструктор
    void update() override;
    void draw(HDC hdc) override;
    int getHealth() const;
    void takeDamage();
};

// Определяем класс Boss
class DLL_API Boss : public Entity {
private:
    int health;
    chrono::steady_clock::time_point lastShootTime;
public:
    Boss(int x, int y);
    virtual ~Boss(); // Добавляем деструктор
    void update() override;
    void draw(HDC hdc) override;
    int getHealth() const;
    void takeDamage();
};
