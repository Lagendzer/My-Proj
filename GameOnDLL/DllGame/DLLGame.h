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

// ���������� activeEnemies � bossSpawned ������ ���� ���������� � ����� cpp-�����.
extern int activeEnemies;
extern bool bossSpawned;

// ���������� ����� Leaks ��� ��������������� ������ _CrtDumpMemoryLeaks()
struct Leaks {
    ~Leaks() {
        _CrtDumpMemoryLeaks();
    }
};
extern Leaks _l;

// ���������� ��������� Point ��� �������� ��������� �����
struct DLL_API Point {
    int x, y;
    Point(int _x, int _y) : x(_x), y(_y) {}
};

// ������������ EntityType ��� ����������� ���� ��������
enum DLL_API EntityType {
    PLAYER,
    ENEMY,
    BULLET,
    OBSTACLE,
    BOSS
};

// ���������� ����� Entity
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

// ������� checkCollision ��� �������� �������� ����� ����� ����������
DLL_API bool checkCollision(const Entity& e1, const Entity& e2);

// ���������� ����� Bullet
class DLL_API Bullet : public Entity {
    float velocityX;
    float velocityY;
public:
    Bullet(int startX, int startY, int targetX, int targetY);
    virtual ~Bullet(); // ��������� ����������
    void update() override;
    void draw(HDC hdc) override;
};

// ���������� ����� Obstacle
class DLL_API Obstacle : public Entity {
public:
    Obstacle(int x, int y);
    virtual ~Obstacle(); // ��������� ����������
    void update() override;
    void draw(HDC hdc) override;
};

// ���������� ����� Player
class DLL_API Player : public Entity {
private:
    int health;
public:
    bool playerMovingUp;
    bool playerMovingDown;
    bool playerMovingLeft;
    bool playerMovingRight;
    Player(int x, int y);
    virtual ~Player(); // ��������� ����������
    void update() override;
    void draw(HDC hdc) override;
    int getHealth() const;
};

// ���������� ����� Enemy
class DLL_API Enemy : public Entity {
private:
    int health;
public:
    Enemy(int x, int y);
    virtual ~Enemy(); // ��������� ����������
    void update() override;
    void draw(HDC hdc) override;
    int getHealth() const;
    void takeDamage();
};

// ���������� ����� Boss
class DLL_API Boss : public Entity {
private:
    int health;
    chrono::steady_clock::time_point lastShootTime;
public:
    Boss(int x, int y);
    virtual ~Boss(); // ��������� ����������
    void update() override;
    void draw(HDC hdc) override;
    int getHealth() const;
    void takeDamage();
};
