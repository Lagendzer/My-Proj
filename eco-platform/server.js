import express from 'express';
import fetch from 'node-fetch';
import cors from 'cors';
import { config } from 'dotenv';
import pkg from 'pg';
import path from 'path';
import { fileURLToPath } from 'url';

config();
const { Pool } = pkg;

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

const app = express();
app.use(cors());
app.use(express.json());
app.use(express.static(path.join(__dirname, 'public')));

const pool = new Pool({
  host: process.env.PG_HOST,
  port: process.env.PG_PORT,
  database: process.env.PG_DATABASE,
  user: process.env.PG_USER,
  password: process.env.PG_PASSWORD,
  ssl: { rejectUnauthorized: false }
});

// ======================= Инициализация БД =======================
async function initDatabase() {
  try {
    await pool.query(`
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

      CREATE TABLE IF NOT EXISTS "Отчеты" (
        "ID" SERIAL PRIMARY KEY,
        "Пользователь_ID" INT REFERENCES "Пользователи"("ID") ON DELETE CASCADE,
        "Тип_отхода_ID" INT REFERENCES "Типы_отходов"("ID") ON DELETE CASCADE,
        "Пункт_ID" INT REFERENCES "Пункты_приема"("ID") ON DELETE CASCADE,
        "Вес_в_кг" DECIMAL(10,2),
        "Дата_сдачи" DATE
      );

      CREATE TABLE IF NOT EXISTS "Друзья" (
        "Пользователь_ID" INT,
        "Друг_ID" INT,
        "Дата_добавления" TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
        PRIMARY KEY ("Пользователь_ID", "Друг_ID"),
        FOREIGN KEY ("Пользователь_ID") REFERENCES "Пользователи"("ID") ON DELETE CASCADE,
        FOREIGN KEY ("Друг_ID") REFERENCES "Пользователи"("ID") ON DELETE CASCADE
      );

      CREATE TABLE IF NOT EXISTS "Достижения" (
        "ID" SERIAL PRIMARY KEY,
        "Название" VARCHAR(100),
        "Описание" TEXT
      );

      CREATE TABLE IF NOT EXISTS "Достижения_пользователей" (
        "Пользователь_ID" INT,
        "Достижение_ID" INT,
        "Дата_получения" DATE DEFAULT CURRENT_DATE,
        PRIMARY KEY ("Пользователь_ID", "Достижение_ID"),
        FOREIGN KEY ("Пользователь_ID") REFERENCES "Пользователи"("ID") ON DELETE CASCADE,
        FOREIGN KEY ("Достижение_ID") REFERENCES "Достижения"("ID") ON DELETE CASCADE
      );
    `);

    const result = await pool.query(`SELECT COUNT(*) FROM "Пользователи"`);
    if (+result.rows[0].count === 0) {
      await pool.query(`
        INSERT INTO "Пользователи" ("Логин", "Почта", "Пароль_хеш") VALUES
          ('eco_user', 'eco@example.com', 'hash123'),
          ('greenqueen', 'queen@eco.ru', 'hash456');

        INSERT INTO "Типы_отходов" ("Название", "Описание") VALUES
          ('Бумага', 'Макулатура и картон'),
          ('Пластик', 'Бутылки и упаковка');

        INSERT INTO "Пункты_приема" ("Название", "Адрес", "Широта", "Долгота") VALUES
          ('ЭкоПункт 1', 'ул. Лесная, 10', 55.75, 37.61),
          ('Зелёный Центр', 'пр. Эко, 25', 55.76, 37.62);

        INSERT INTO "Отчеты" ("Пользователь_ID", "Тип_отхода_ID", "Пункт_ID", "Вес_в_кг", "Дата_сдачи") VALUES
          (1, 1, 1, 3.5, CURRENT_DATE),
          (2, 2, 2, 1.2, CURRENT_DATE);

        INSERT INTO "Достижения" ("Название", "Описание") VALUES
          ('Первый отчёт', 'Сделал первый вклад'),
          ('Эко-герой', 'Сдал более 3 кг');

        INSERT INTO "Достижения_пользователей" ("Пользователь_ID", "Достижение_ID") VALUES
          (1, 1),
          (1, 2),
          (2, 1);

        INSERT INTO "Друзья" ("Пользователь_ID", "Друг_ID") VALUES
          (1, 2),
          (2, 1);
      `);
      console.log('✅ База данных инициализирована и заполнена');
    } else {
      console.log('ℹ️ Таблицы уже существуют');
    }
  } catch (err) {
    console.error('❌ Ошибка инициализации БД:', err);
  }
}
initDatabase();

// ======================= ТВОЙ BACKEND =======================

app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'index.html'));
});

// Получение всех типов отходов
app.get('/api/waste-types', async (req, res) => {
  try {
    const result = await pool.query('SELECT * FROM "Типы_отходов"');
    res.json(result.rows);
  } catch (err) {
    res.status(500).json({ message: 'Ошибка при получении типов отходов' });
  }
});


app.get('/api/points', async (req, res) => {
  try {
    const result = await pool.query('SELECT * FROM "Пункты_приема"');
    res.json(result.rows);
  } catch (err) {
    res.status(500).json({ error: 'Ошибка сервера' });
  }
});

app.get('/api/get-coordinates', async (req, res) => {
  const address = req.query.address;
  if (!address) return res.status(400).json({ message: 'Адрес не указан' });

  try {
    const response = await fetch(`https://nominatim.openstreetmap.org/search?format=json&q=${encodeURIComponent(address)}`);
    const data = await response.json();
    if (data.length === 0) return res.status(404).json({ message: 'Адрес не найден' });

    const { lat, lon } = data[0];
    res.json({ lat, lon });
  } catch (err) {
    res.status(500).json({ message: 'Ошибка при получении координат' });
  }
});

app.get('/api/reports', async (req, res) => {
  try {
    const query = `
      SELECT o.*, u."Почта" AS email, t."Название" AS waste_type, p."Название" AS point
      FROM "Отчеты" o
      JOIN "Пользователи" u ON o."Пользователь_ID" = u."ID"
      JOIN "Типы_отходов" t ON o."Тип_отхода_ID" = t."ID"
      JOIN "Пункты_приема" p ON o."Пункт_ID" = p."ID"
    `;
    const result = await pool.query(query);
    res.json(result.rows);
  } catch (err) {
    res.status(500).json({ error: 'Ошибка при получении отчётов' });
  }
});

app.post('/api/reports', async (req, res) => {
  const { Почта, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи } = req.body;
  try {
    const user = await pool.query('SELECT "ID" FROM "Пользователи" WHERE "Почта" = $1', [Почта]);
    if (user.rows.length === 0) return res.status(404).json({ message: 'Пользователь не найден' });

    await pool.query(
      `INSERT INTO "Отчеты" ("Пользователь_ID", "Тип_отхода_ID", "Пункт_ID", "Вес_в_кг", "Дата_сдачи")
       VALUES ($1, $2, $3, $4, $5)`,
      [user.rows[0].ID, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи]
    );
    res.json({ success: true });
  } catch (err) {
    res.status(500).json({ message: 'Ошибка при добавлении отчёта' });
  }
});

app.get('/api/ranking', async (req, res) => {
  try {
    const result = await pool.query(`
      SELECT u."Почта", SUM(o."Вес_в_кг") AS "Вклад"
      FROM "Отчеты" o
      JOIN "Пользователи" u ON o."Пользователь_ID" = u."ID"
      GROUP BY u."Почта"
      ORDER BY "Вклад" DESC
    `);
    res.json(result.rows);
  } catch (err) {
    res.status(500).json({ message: 'Ошибка при получении рейтинга' });
  }
});

app.get('/api/search-email/:query', async (req, res) => {
  try {
    const { query } = req.params;
    const result = await pool.query(
      'SELECT "Почта" FROM "Пользователи" WHERE "Почта" ILIKE $1',
      [`%${query}%`]
    );
    res.json(result.rows);
  } catch (err) {
    res.status(500).json({ message: 'Ошибка при поиске почты' });
  }
});

app.get('/api/vklad/:email', async (req, res) => {
  try {
    const email = req.params.email;
    const result = await pool.query(`
      SELECT SUM("Вес_в_кг") AS total
      FROM "Отчеты" o
      JOIN "Пользователи" u ON o."Пользователь_ID" = u."ID"
      WHERE u."Почта" = $1
    `, [email]);

    const вес = parseFloat(result.rows[0].total || 0);
    let достижение = '⛔ Пока ничего не сдано';
    if (вес > 0) достижение = '🗑️ Начал путь!';
    if (вес >= 20) достижение = '🌱 Молодец!';
    if (вес >= 50) достижение = '♻ Эко-герой!';

    res.json({ вес, достижение });
  } catch (err) {
    res.status(500).json({ message: 'Ошибка при подсчёте вклада' });
  }
});

app.post('/api/add-waste-type', async (req, res) => {
  const { Название, Описание } = req.body;
  try {
    await pool.query(
      'INSERT INTO "Типы_отходов" ("Название", "Описание") VALUES ($1, $2)',
      [Название, Описание]
    );
    res.status(201).json({ message: 'Тип отхода добавлен' });
  } catch (err) {
    res.status(500).json({ message: 'Ошибка при добавлении типа отхода' });
  }
});

app.post('/api/chat', async (req, res) => {
  const { message } = req.body;

  if (!message) {
    return res.status(400).json({ reply: "Сообщение не указано." });
  }

  try {
    const response = await fetch("https://openrouter.ai/api/v1/chat/completions", {
  method: "POST",
  headers: {
    "Authorization": `Bearer ${process.env.OPENROUTER_API_KEY}`,
    "Content-Type": "application/json"
  },
  body: JSON.stringify({
    model: "openai/gpt-3.5-turbo",
    messages: [
      { role: "system", content: "Ты бот по экологии, утилизации и переработке отходов." },
      { role: "user", content: message }
    ]
  })
});


    const data = await response.json();

    if (!data.choices || !data.choices[0]) {
      console.error("OpenRouter error:", data);
      return res.status(500).json({ reply: "Ошибка генерации ответа." });
    }

    res.json({ reply: data.choices[0].message.content });

  } catch (err) {
    console.error("Ошибка чата:", err);
    res.status(500).json({ reply: "Ошибка подключения к нейросети." });
  }
});


// Запуск сервера
const PORT = process.env.PORT || 10000;
console.log("OPENROUTER_API_KEY:", process.env.OPENROUTER_API_KEY);
app.listen(PORT, () => {
  console.log(`🚀 Сервер запущен на порту ${PORT}`);
});
