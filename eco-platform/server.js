const express = require('express');
const mysql = require('mysql2');
const cors = require('cors');
const path = require('path');
const fetch = (...args) => import('node-fetch').then(({ default: fetch }) => fetch(...args));

const app = express();
app.use(express.json());
app.use(cors());
app.use(express.static(path.join(__dirname)));

// Подключение к MySQL
const db = mysql.createConnection({
  host: process.env.DB_HOST || 'localhost',
  user: process.env.DB_USER || 'cj27830_ecoplat',
  password: process.env.DB_PASS || '8YafUjS9',
  database: process.env.DB_NAME || 'cj27830_ecoplat'
});

db.connect(err => {
  if (err) {
    console.error('❌ Ошибка подключения к MySQL:', err);
  } else {
    console.log('✅ Подключение к MySQL установлено!');
  }
});

// Главная страница
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'index.html'));
});

// Нейросеть через OpenRouter
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
    console.error('Ошибка OpenRouter:', err);
    res.status(500).json({ reply: "Ошибка подключения к нейросети." });
  }
});

// Пункты приёма
app.get('/api/points', (req, res) => {
  db.query('SELECT * FROM `Пункты_приема`', (err, results) => {
    if (err) return res.status(500).json({ message: 'Ошибка сервера' });
    res.json(results);
  });
});

// Получение координат
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
    console.error('Ошибка координат:', err);
    res.status(500).json({ message: 'Ошибка сервера' });
  }
});

// Все отчёты
app.get('/api/reports', (req, res) => {
  const sql = `
    SELECT O.ID, P.Почта, T.Название AS Тип_отхода, P2.Название AS Пункт, O.Вес_в_кг, O.Дата_сдачи
    FROM Отчеты O
    JOIN Типы_отходов T ON O.Тип_отхода_ID = T.ID
    JOIN Пункты_приема P2 ON O.Пункт_ID = P2.ID
    JOIN Пользователи P ON O.Пользователь_ID = P.ID
  `;
  db.query(sql, (err, results) => {
    if (err) return res.status(500).json({ message: 'Ошибка сервера' });
    res.json(results);
  });
});

// Добавить отчёт
app.post('/api/reports', (req, res) => {
  const { Почта, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи } = req.body;

  db.query('SELECT ID FROM Пользователи WHERE Почта = ?', [Почта], (err, results) => {
    if (err || results.length === 0) return res.status(400).json({ message: 'Пользователь не найден' });

    const пользовательID = results[0].ID;
    const insert = `
      INSERT INTO Отчеты (Пользователь_ID, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи)
      VALUES (?, ?, ?, ?, ?)
    `;
    db.query(insert, [пользовательID, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи], (err) => {
      if (err) return res.status(500).json({ message: 'Ошибка сервера' });
      res.status(201).json({ message: 'Отчёт добавлен' });
    });
  });
});

// Рейтинг
app.get('/api/ranking', (req, res) => {
  const sql = `
    SELECT P.Почта, SUM(O.Вес_в_кг) AS Вклад
    FROM Отчеты O
    JOIN Пользователи P ON O.Пользователь_ID = P.ID
    GROUP BY P.Почта
    ORDER BY Вклад DESC
  `;
  db.query(sql, (err, results) => {
    if (err) return res.status(500).json({ message: 'Ошибка сервера' });
    res.json(results);
  });
});

// Поиск почты
app.get('/api/search-email/:query', (req, res) => {
  const search = `%${req.params.query}%`;
  db.query('SELECT Почта FROM Пользователи WHERE Почта LIKE ?', [search], (err, results) => {
    if (err) return res.status(500).json({ message: 'Ошибка сервера' });
    res.json(results);
  });
});

// Вклад пользователя
app.get('/api/vklad/:email', (req, res) => {
  db.query(`
    SELECT SUM(Вес_в_кг) AS ОбщийВес
    FROM Отчеты O
    JOIN Пользователи P ON O.Пользователь_ID = P.ID
    WHERE P.Почта = ?
  `, [req.params.email], (err, results) => {
    if (err) return res.status(500).json({ message: 'Ошибка сервера' });

    const вес = results[0].ОбщийВес || 0;
    let достижение = '';
    if (вес >= 50) достижение = '♻ Эко-герой!';
    else if (вес >= 20) достижение = '🌱 Молодец!';
    else if (вес > 0) достижение = '🗑️ Начал путь!';
    else достижение = '⛔ Пока ничего не сдано';

    res.json({ вес, достижение });
  });
});

// Добавление нового типа отхода
app.post('/api/add-waste-type', (req, res) => {
  const { Название, Описание } = req.body;
  db.query(
    'INSERT INTO Типы_отходов (Название, Описание) VALUES (?, ?)',
    [Название, Описание],
    (err) => {
      if (err) return res.status(500).json({ message: 'Ошибка сервера' });
      res.status(201).json({ message: 'Тип отхода добавлен' });
    }
  );
});

// Запуск сервера
const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
  console.log(`🚀 Сервер запущен на порту ${PORT}`);
});
