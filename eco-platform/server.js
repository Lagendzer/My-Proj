const express = require('express');
const sql = require('mssql');
const cors = require('cors');
const path = require('path');
const fetch = (...args) => import('node-fetch').then(({ default: fetch }) => fetch(...args)); // fetch для Node.js

const app = express();
app.use(express.json());
app.use(cors());
app.use(express.static(path.join(__dirname)));

const config = {
  user: 'eco_user',
  password: 'Qwerty123!',
  server: 'localhost',
  database: 'ЭкоПлатформа',
  options: {
    encrypt: false,
    trustServerCertificate: true
  }
};

sql.connect(config)
  .then(() => console.log('✅ Подключено к базе данных SQL Server'))
  .catch(err => console.error('❌ Ошибка подключения:', err));

// Главная страница
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'index.html'));
});

// Маршрут чата с OpenRouter
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

    if (!response.ok) {
      const err = await response.json();
      console.error("Ошибка OpenRouter:", err);
      return res.status(500).json({ reply: "Ошибка: " + (err.error?.message || "не удалось получить ответ") });
    }

    const data = await response.json();
    res.json({ reply: data.choices[0].message.content });

  } catch (err) {
    console.error("Ошибка подключения к OpenRouter:", err);
    res.status(500).json({ reply: "Ошибка подключения к нейросети." });
  }
});

// Пункты приёма
app.get('/api/points', async (req, res) => {
  try {
    const pool = await sql.connect(config);
    const result = await pool.request().query('SELECT * FROM Пункты_приема');
    res.json(result.recordset);
  } catch {
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Получение координат по адресу
app.get('/api/get-coordinates', async (req, res) => {
  const address = req.query.address;

  if (!address) return res.status(400).json({ message: 'Адрес не указан' });

  const encodedAddress = encodeURIComponent(address);
  const apiUrl = `https://nominatim.openstreetmap.org/search?format=json&q=${encodedAddress}`;

  try {
    const response = await fetch(apiUrl);
    const data = await response.json();
    if (data.length === 0) return res.status(404).json({ message: 'Адрес не найден' });

    const { lat, lon } = data[0];
    res.json({ lat, lon });
  } catch (err) {
    console.error('Ошибка при получении координат:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Получить все отчёты
app.get('/api/reports', async (req, res) => {
  try {
    const pool = await sql.connect(config);
    const result = await pool.request().query(`
      SELECT O.ID, P.Почта, T.Название AS Тип_отхода, P2.Название AS Пункт, O.Вес_в_кг, O.Дата_сдачи
      FROM Отчеты O
      JOIN Типы_отходов T ON O.Тип_отхода_ID = T.ID
      JOIN Пункты_приема P2 ON O.Пункт_ID = P2.ID
      JOIN Пользователи P ON O.Пользователь_ID = P.ID
    `);
    res.json(result.recordset);
  } catch (err) {
    console.error('Ошибка при получении отчётов:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Добавление отчёта
app.post('/api/reports', async (req, res) => {
  const { Почта, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи } = req.body;
  try {
    const pool = await sql.connect(config);
    const userResult = await pool.request()
      .input('Почта', sql.NVarChar, Почта)
      .query('SELECT ID FROM Пользователи WHERE Почта = @Почта');

    if (userResult.recordset.length === 0) {
      return res.status(400).json({ message: 'Пользователь с такой почтой не найден' });
    }

    const пользовательID = userResult.recordset[0].ID;

    await pool.request()
      .input('Пользователь_ID', sql.Int, пользовательID)
      .input('Тип_отхода_ID', sql.Int, Тип_отхода_ID)
      .input('Пункт_ID', sql.Int, Пункт_ID)
      .input('Вес_в_кг', sql.Decimal(10, 2), Вес_в_кг)
      .input('Дата_сдачи', sql.Date, Дата_сдачи)
      .query(`INSERT INTO Отчеты (Пользователь_ID, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи)
              VALUES (@Пользователь_ID, @Тип_отхода_ID, @Пункт_ID, @Вес_в_кг, @Дата_сдачи)`);

    res.status(201).json({ message: 'Отчёт добавлен' });
  } catch (err) {
    console.error('Ошибка при добавлении отчёта:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Получить рейтинг пользователей
app.get('/api/ranking', async (req, res) => {
  try {
    const pool = await sql.connect(config);
    const result = await pool.request().query(`
      SELECT P.Почта, SUM(O.Вес_в_кг) AS Вклад
      FROM Отчеты O
      JOIN Пользователи P ON O.Пользователь_ID = P.ID
      GROUP BY P.Почта
      ORDER BY Вклад DESC
    `);
    res.json(result.recordset);
  } catch (err) {
    console.error('Ошибка при получении рейтинга:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Поиск почты пользователя
app.get('/api/search-email/:query', async (req, res) => {
  const query = req.params.query;

  try {
    const pool = await sql.connect(config);
    const result = await pool.request()
      .input('query', sql.NVarChar, `%${query}%`)
      .query('SELECT Почта FROM Пользователи WHERE Почта LIKE @query');
    res.json(result.recordset);
  } catch (err) {
    console.error('Ошибка поиска почты:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Получение вклада
app.get('/api/vklad/:email', async (req, res) => {
  const email = req.params.email;

  try {
    const pool = await sql.connect(config);
    const result = await pool.request()
      .input('email', sql.NVarChar, email)
      .query(`
        SELECT SUM(Вес_в_кг) AS ОбщийВес
        FROM Отчеты O
        JOIN Пользователи P ON O.Пользователь_ID = P.ID
        WHERE P.Почта = @email
      `);

    const вес = result.recordset[0].ОбщийВес || 0;
    let достижение = '';
    if (вес >= 50) достижение = '♻ Эко-герой!';
    else if (вес >= 20) достижение = '🌱 Молодец!';
    else if (вес > 0) достижение = '🗑️ Начал путь!';
    else достижение = '⛔ Пока ничего не сдано';

    res.json({ вес, достижение });
  } catch (err) {
    console.error('Ошибка при расчете вклада:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Добавление нового типа отхода
app.post('/api/add-waste-type', async (req, res) => {
  const { Название, Описание } = req.body;

  try {
    const pool = await sql.connect(config);
    await pool.request()
      .input('Название', sql.NVarChar, Название)
      .input('Описание', sql.NVarChar, Описание)
      .query('INSERT INTO Типы_отходов (Название, Описание) VALUES (@Название, @Описание)');

    res.status(201).json({ message: 'Тип отхода добавлен' });
  } catch (err) {
    console.error('Ошибка при добавлении типа отхода:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Запуск сервера
const PORT = 3000;
app.listen(PORT, () => {
  console.log(`🚀 Сервер запущен: http://localhost:${PORT}`);
});
