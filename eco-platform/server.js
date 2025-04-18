import express from 'express';
import fetch from 'node-fetch';
import cors from 'cors';
import { config } from 'dotenv';
import pkg from 'pg';
import path from 'path';
import { fileURLToPath } from 'url';

config();
const { Pool } = pkg;

// абсолютный путь (нужен для sendFile)
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

const app = express();
app.use(cors());
app.use(express.json());
app.use(express.static(path.join(__dirname, 'public')));

// PostgreSQL pool
const pool = new Pool({
  host: process.env.PG_HOST,
  port: process.env.PG_PORT,
  database: process.env.PG_DATABASE,
  user: process.env.PG_USER,
  password: process.env.PG_PASSWORD,
  ssl: { rejectUnauthorized: false }
});

// Главная страница
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'index.html'));
});

// Получение всех пунктов приёма
app.get('/api/points', async (req, res) => {
  try {
    const result = await pool.query('SELECT * FROM "Пункты_приема"');
    res.json(result.rows);
  } catch (err) {
    res.status(500).json({ error: 'Ошибка сервера' });
  }
});

// Получение координат через OpenStreetMap
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

// Все отчёты
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

// Добавление отчёта
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

// Рейтинг
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

// Поиск почты
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

// Вклад пользователя
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

// Добавление нового типа отхода
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

// Чат с нейросетью через OpenRouter
app.post('/api/chat', async (req, res) => {
  const { message } = req.body;
  try {
    const response = await fetch("https://openrouter.ai/api/v1/chat/completions", {
      headers: {
        "Authorization": "Bearer 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",
        "Content-Type": "application/json"
      },
      method: "POST",
      body: JSON.stringify({
        model: "openai/gpt-3.5-turbo",
        messages: [
          { role: "system", content: "Ты бот по экологии, утилизации и переработке отходов. Отвечай только по этим темам." },
          { role: "user", content: message }
        ]
      })
    });

    const data = await response.json();
    res.json({ reply: data.choices[0].message.content });
  } catch (err) {
    res.status(500).json({ reply: "Ошибка подключения к нейросети." });
  }
});

// Запуск сервера
const PORT = process.env.PORT || 10000;
app.listen(PORT, () => {
  console.log(`🚀 Сервер запущен на порту ${PORT}`);
});
