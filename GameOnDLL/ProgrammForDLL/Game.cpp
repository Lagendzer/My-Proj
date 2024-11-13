#include <Windows.h>
#include <vector>
#include <cstdlib>
#include <ctime>
#include <algorithm>
#include <iterator>
#include <set>
#include <map>
#include <chrono>
#include <iostream>
#include <thread>
#include "Game.h"
#include "DLLGame.h"

using namespace std;

const int WIDTH = 800;
const int HEIGHT = 600;
const int PLAYER_SIZE = 20;
const int ENEMY_SIZE = 30;
const int BOSS_SIZE = 50;
const int OBSTACLE_SIZE = 40;
const int BULLET_SIZE = 5;
const int MOVE_SPEED = 5;
const int BULLET_SPEED = 10;
const int BOSS_SHOOT_DELAY = 1000;

vector<Entity*> entities;

LRESULT CALLBACK WndProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam) {
    HDC hdc;
    PAINTSTRUCT ps;
    static Player player(100, 100); // Сделаем статическим

    switch (message) {
    case WM_CREATE:
        entities.push_back(&player); // Добавляем адрес статического игрока в вектор
        for (int i = 0; i < 8; i++) {
            int x = rand() % (WIDTH - ENEMY_SIZE);
            int y = rand() % (HEIGHT - ENEMY_SIZE);
            entities.push_back(new Enemy(x, y));
        }

        for (int i = 0; i < 15; i++) {
            int x, y;
            do {
                x = rand() % (WIDTH - OBSTACLE_SIZE);
                y = rand() % (HEIGHT - OBSTACLE_SIZE);
            } while (checkCollision(player, Obstacle(x, y)));
            entities.push_back(new Obstacle(x, y));
        }
        break;

    case WM_PAINT:
        hdc = BeginPaint(hwnd, &ps);
        HBRUSH hBrush;
        hBrush = CreateSolidBrush(RGB(255, 255, 255));
        SelectObject(hdc, hBrush);
        Rectangle(hdc, 0, 0, WIDTH, HEIGHT);
        DeleteObject(hBrush);
        for (auto entity : entities)
            entity->draw(hdc);
        EndPaint(hwnd, &ps);
        break;

    case WM_KEYDOWN:
        switch (wParam) {
        case VK_UP:
            player.playerMovingUp = true;
            break;
        case VK_DOWN:
            player.playerMovingDown = true;
            break;
        case VK_LEFT:
            player.playerMovingLeft = true;
            break;
        case VK_RIGHT:
            player.playerMovingRight = true;
            break;
        }
        break;

    case WM_KEYUP:
        switch (wParam) {
        case VK_UP:
            player.playerMovingUp = false;
            break;
        case VK_DOWN:
            player.playerMovingDown = false;
            break;
        case VK_LEFT:
            player.playerMovingLeft = false;
            break;
        case VK_RIGHT:
            player.playerMovingRight = false;
            break;
        }
        break;

    case WM_LBUTTONDOWN:
    {
        POINT cursorPos;
        GetCursorPos(&cursorPos);
        ScreenToClient(hwnd, &cursorPos);
        entities.push_back(new Bullet(player.getPosition().x + PLAYER_SIZE / 2, player.getPosition().y + PLAYER_SIZE / 2, cursorPos.x, cursorPos.y));
    }
    break;

    case WM_TIMER:
        for (auto entity : entities)
            entity->update();

        // Проверка столкновений пуль с врагами и обработка попаданий
        for (auto bulletIter = entities.begin(); bulletIter != entities.end(); ++bulletIter) {
            if ((*bulletIter)->getType() == BULLET) {
                Bullet* bullet = dynamic_cast<Bullet*>(*bulletIter);
                for (auto enemyIter = entities.begin(); enemyIter != entities.end(); ++enemyIter) {
                    if ((*enemyIter)->getType() == ENEMY) {
                        Enemy* enemy = dynamic_cast<Enemy*>(*enemyIter);
                        if (checkCollision(*bullet, *enemy)) {
                            enemy->takeDamage();
                            bullet->setDestroyed(true);
                        }
                    }
                    else if ((*enemyIter)->getType() == BOSS) {
                        Boss* boss = dynamic_cast<Boss*>(*enemyIter);
                        if (checkCollision(*bullet, *boss)) {
                            boss->takeDamage();
                            bullet->setDestroyed(true);
                        }
                    }
                }
            }
        }

        // Проверка столкновений пуль с препятствиями и выход за экран
        for (auto bulletIter = entities.begin(); bulletIter != entities.end(); ++bulletIter) {
            if ((*bulletIter)->getType() == BULLET) {
                Bullet* bullet = dynamic_cast<Bullet*>(*bulletIter);

                // Проверяем, вышла ли пуля за границы экрана
                if (bullet->getPosition().x < 0 || bullet->getPosition().x > WIDTH ||
                    bullet->getPosition().y < 0 || bullet->getPosition().y > HEIGHT) {
                    bullet->setDestroyed(true); // Помечаем пулю на удаление
                }

                for (auto obstacleIter = entities.begin(); obstacleIter != entities.end(); ++obstacleIter) {
                    if ((*obstacleIter)->getType() == OBSTACLE) {
                        Obstacle* obstacle = dynamic_cast<Obstacle*>(*obstacleIter);
                        if (checkCollision(*bullet, *obstacle)) {
                            bullet->setDestroyed(true);
                        }
                    }
                }
            }
        }

        // Удаление уничтоженных врагов, пуль и босса
        entities.erase(std::remove_if(entities.begin(), entities.end(),
            [](Entity* entity) { return entity->isDestroyed(); }), entities.end());

        InvalidateRect(hwnd, NULL, FALSE);
        break;

    case WM_DESTROY:
        for (auto entity : entities) {
            if (entity != &player) // Не удаляем статический объект
                delete entity;
        }
        PostQuitMessage(0);
        break;

    default:
        return DefWindowProc(hwnd, message, wParam, lParam);
    }
    return 0;
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow) {
    WNDCLASSEX wc;
    HWND hwnd;
    MSG msg;
    const wchar_t CLASS_NAME[] = L"MainWindow";

    wc.cbSize = sizeof(WNDCLASSEX);
    wc.style = 0;
    wc.lpfnWndProc = WndProc;
    wc.cbClsExtra = 0;
    wc.cbWndExtra = 0;
    wc.hInstance = hInstance;
    wc.hIcon = LoadIcon(NULL, IDI_APPLICATION);
    wc.hCursor = LoadCursor(NULL, IDC_ARROW);
    wc.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
    wc.lpszMenuName = NULL;
    wc.lpszClassName = CLASS_NAME;
    wc.hIconSm = LoadIcon(NULL, IDI_APPLICATION);

    if (!RegisterClassEx(&wc)) {
        MessageBox(NULL, L"Window Registration Failed!", L"Error!", MB_ICONEXCLAMATION | MB_OK);
        return 0;
    }

    hwnd = CreateWindowEx(
        WS_EX_CLIENTEDGE,
        CLASS_NAME,
        L"Game",
        WS_OVERLAPPEDWINDOW,
        CW_USEDEFAULT, CW_USEDEFAULT, WIDTH, HEIGHT,
        NULL, NULL, hInstance, NULL);

    if (hwnd == NULL) {
        MessageBox(NULL, L"Window Creation Failed!", L"Error!", MB_ICONEXCLAMATION | MB_OK);
        return 0;
    }

    ShowWindow(hwnd, nCmdShow);
    UpdateWindow(hwnd);

    SetTimer(hwnd, 1, 50, NULL);

    while (GetMessage(&msg, NULL, 0, 0) > 0) {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }

    return msg.wParam;
}
