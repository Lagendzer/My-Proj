import { config } from 'dotenv';
import pkg from 'pg';

config();
const { Pool } = pkg;

const pool = new Pool({
  host: process.env.PG_HOST,
  port: process.env.PG_PORT,
  database: process.env.PG_DATABASE,
  user: process.env.PG_USER,
  password: process.env.PG_PASSWORD,
  ssl: { rejectUnauthorized: false }
});

const sql = `
CREATE TABLE IF NOT EXISTS "Пользователи" (
  "ID" SERIAL PRIMARY KEY,
  "Логин" VARCHAR(50),
  "Почта" VARCHAR(100),
  "Пароль_хеш" VARCHAR(255),
  "Дата_регистрации" TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS "Типы_отходов" (
  "ID" SERIAL PRIMARY KEY,
  "Название" VARCHAR(100),
  "Описание" TEXT
);

CREATE TABLE IF NOT EXISTS "Пункты_приема" (
  "ID" SERIAL PRIMARY KEY,
  "Название" VARCHAR(150),
  "Адрес" VARCHAR(255),
  "Широта" FLOAT,
  "Долгота" FLOAT
);

CREATE TABLE IF NOT EXISTS "Достижения" (
  "ID" SERIAL PRIMARY KEY,
  "Название" VARCHAR(100),
  "Описание" TEXT
);

CREATE TABLE IF NOT EXISTS "Достижения_пользователей" (
  "Пользователь_ID" INT REFERENCES "Пользователи"("ID") ON DELETE CASCADE,
  "Достижение_ID" INT REFERENCES "Достижения"("ID") ON DELETE CASCADE,
  "Дата_получения" DATE DEFAULT CURRENT_DATE,
  PRIMARY KEY ("Пользователь_ID", "Достижение_ID")
);

CREATE TABLE IF NOT EXISTS "Друзья" (
  "Пользователь_ID" INT REFERENCES "Пользователи"("ID") ON DELETE CASCADE,
  "Друг_ID" INT REFERENCES "Пользователи"("ID") ON DELETE CASCADE,
  "Дата_добавления" TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY ("Пользователь_ID", "Друг_ID")
);

CREATE TABLE IF NOT EXISTS "Отчеты" (
  "ID" SERIAL PRIMARY KEY,
  "Пользователь_ID" INT REFERENCES "Пользователи"("ID") ON DELETE CASCADE,
  "Тип_отхода_ID" INT REFERENCES "Типы_отходов"("ID") ON DELETE CASCADE,
  "Пункт_ID" INT REFERENCES "Пункты_приема"("ID") ON DELETE CASCADE,
  "Вес_в_кг" DECIMAL(10, 2),
  "Дата_сдачи" DATE
);

-- Примерные данные
INSERT INTO "Пользователи" ("Логин", "Почта", "Пароль_хеш") VALUES
('eco_user1', 'user1@example.com', 'hash1'),
('eco_user2', 'user2@example.com', 'hash2');

INSERT INTO "Типы_отходов" ("Название", "Описание") VALUES
('Пластик', 'Пластиковые бутылки и упаковка'),
('Бумага', 'Газеты, картон, бумажные упаковки');

INSERT INTO "Пункты_приема" ("Название", "Адрес", "Широта", "Долгота") VALUES
('Экопункт №1', 'ул. Зеленая, 5', 55.751244, 37.618423),
('Экопункт №2', 'пр-т Эко, 12', 55.755814, 37.617635);

INSERT INTO "Достижения" ("Название", "Описание") VALUES
('Первый отчёт', 'Вы сдали свой первый мусор!'),
('Эко-герой', '10 успешных отчётов подряд!');

INSERT INTO "Отчеты" ("Пользователь_ID", "Тип_отхода_ID", "Пункт_ID", "Вес_в_кг", "Дата_сдачи") VALUES
(1, 1, 1, 2.5, '2025-04-17'),
(2, 2, 2, 1.2, '2025-04-17');

INSERT INTO "Достижения_пользователей" ("Пользователь_ID", "Достижение_ID") VALUES
(1, 1),
(2, 1);

INSERT INTO "Друзья" ("Пользователь_ID", "Друг_ID") VALUES
(1, 2),
(2, 1);
`;

async function run() {
  try {
    await pool.query(sql);
    console.log('✅ Полная база данных создана и заполнена!');
    process.exit(0);
  } catch (err) {
    console.error('❌ Ошибка при создании базы:', err);
    process.exit(1);
  }
}

run();
