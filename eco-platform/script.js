document.addEventListener('DOMContentLoaded', function () {
  const aboutProjectButton = document.getElementById("aboutProjectButton");
  const aboutProjectModal = document.getElementById("aboutProjectModal");
  const addWasteTypeModal = document.getElementById("addWasteTypeModal");

  // Открытие модального окна "О проекте"
  if (aboutProjectButton && aboutProjectModal) {
    aboutProjectButton.onclick = function () {
      aboutProjectModal.style.display = "flex";
    }
  }

  // Открытие модального окна для добавления нового типа отхода
  document.getElementById("saveWasteTypeBtn").addEventListener('click', async () => {
    const newWasteType = document.getElementById('newWasteType').value;
    const newWasteDescription = document.getElementById('newWasteDescription').value;

    if (newWasteType && newWasteDescription) {
      const res = await fetch('/api/add-waste-type', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ Название: newWasteType, Описание: newWasteDescription }),
      });

      if (res.ok) {
        alert('Тип отхода добавлен!');
        closeAddWasteTypeModal(); // Закрываем модальное окно
      } else {
        alert('Ошибка при добавлении типа отхода');
      }
    } else {
      alert('Пожалуйста, заполните все поля');
    }
  });

  // Функция для закрытия модального окна
  function closeModal() {
    aboutProjectModal.style.display = 'none';
  }

  function closeAddWasteTypeModal() {
    addWasteTypeModal.style.display = 'none';
  }

  // Закрытие модальных окон при клике за пределами
  window.onclick = function (event) {
    if (event.target === aboutProjectModal) {
      closeModal();
    } else if (event.target === addWasteTypeModal) {
      closeAddWasteTypeModal();
    }
  }

  // Функция для открытия модального окна "О проекте"
  window.openAboutProjectModal = function() {
    aboutProjectModal.style.display = "flex";
  }

  // Открытие модального окна для добавления нового типа отхода
  window.openAddWasteTypeModal = function() {
    addWasteTypeModal.style.display = "flex";
  }
});

// Автозаполнение почты для вкладов
document.addEventListener('DOMContentLoaded', function () {
  const vkladEmailInput = document.getElementById('vkladEmail');
  const emailList = document.getElementById('emailList');

  // Функция для автодополнения
  vkladEmailInput.addEventListener('input', async function () {
    const query = vkladEmailInput.value;

    if (query.length > 2) { // Делаем запрос только если введено больше 2 символов
      const res = await fetch(`/api/search-email/${query}`);
      const emails = await res.json();

      emailList.innerHTML = ''; // Очищаем список перед добавлением новых данных
      emails.forEach(email => {
        const option = document.createElement('option');
        option.value = email.Почта;
        emailList.appendChild(option);
      });
    }
  });

  // Функция для подсчёта вклада пользователя по почте
  async function loadVklad() {
    const email = vkladEmailInput.value;
    const res = await fetch(`/api/vklad/${email}`);
    const data = await res.json();
    const out = document.getElementById('vkladResult');
    out.innerHTML = `♻️ Сдано отходов: <strong>${data.вес} кг</strong><br>🏅 Достижение: <strong>${data.достижение}</strong>`;
  }

  // Перемещаем функцию в глобальный scope, чтобы её могли вызывать кнопки
  window.loadVklad = loadVklad;
});

// Функция для добавления отчёта
async function addReport() {
  const Почта = document.getElementById('userEmail').value; // Ввод почты пользователя
  const Тип_отхода_ID = parseInt(document.getElementById('wasteType').value); // Выбор типа отхода
  const Пункт_ID = parseInt(document.getElementById('recyclingPoint').value); // Выбор пункта приёма
  const Вес_в_кг = parseFloat(document.getElementById('weight').value); // Ввод веса
  const Дата_сдачи = document.getElementById('date').value; // Ввод даты сдачи
  const msg = document.getElementById('reportMessage'); // Место для сообщений

  // Проверка на заполненность всех полей
  if (!Почта || !Тип_отхода_ID || !Пункт_ID || !Вес_в_кг || !Дата_сдачи) {
    msg.textContent = '❌ Пожалуйста, заполните все поля';
    msg.style.color = 'red';
    return;
  }

  // Отправка запроса на сервер
  const res = await fetch('/api/reports', {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ Почта, Тип_отхода_ID, Пункт_ID, Вес_в_кг, Дата_сдачи })
  });

  if (res.ok) {
    msg.textContent = '✅ Отчёт отправлен!';
    msg.style.color = '#90ee90';
    loadReports(); // Загружаем новые отчёты
  } else {
    msg.textContent = '❌ Ошибка при отправке отчёта';
    msg.style.color = 'red';
  }
}


// Функция для загрузки и отображения рейтинга
async function loadRanking() {
  const res = await fetch('/api/ranking');
  const ranking = await res.json();
  const table = document.getElementById('rankingTable');
  table.innerHTML = '';  // Очищаем таблицу перед обновлением

  ranking.forEach((user, index) => {
    const row = document.createElement('tr');
    row.innerHTML = `
      <td>${index + 1}</td>  <!-- Место в рейтинге -->
      <td>${user.Почта}</td> <!-- Почта пользователя -->
      <td>${user.Вклад} кг</td> <!-- Вклад -->
    `;
    table.appendChild(row);
  });
}

// Инициализация рейтинга
loadRanking();
setInterval(loadRanking, 5000);  // Обновляем рейтинг каждые 5 секунд

// Функция для добавления нового типа отхода
async function saveNewWasteType() {
  const newWasteType = document.getElementById('newWasteType').value;
  const newWasteDescription = document.getElementById('newWasteDescription').value;

  if (newWasteType && newWasteDescription) {
    const res = await fetch('/api/add-waste-type', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ Название: newWasteType, Описание: newWasteDescription })
    });

    if (res.ok) {
      alert('Тип отхода добавлен!');
      loadWasteTypes();  // Обновляем список типов отходов
      closeAddWasteTypeModal();  // Закрываем модальное окно
    } else {
      alert('Ошибка при добавлении типа отхода');
    }
  } else {
    alert('Пожалуйста, заполните все поля');
  }
}

async function loadWasteTypes() {
  const res = await fetch('/api/waste-types');
  const types = await res.json();
  wasteTypeSelect.innerHTML = '';  // Очищаем select
  types.forEach(type => {
    const option = document.createElement('option');
    option.value = type.ID;
    option.textContent = type.Название;
    wasteTypeSelect.appendChild(option);
  });
}

// Функция для добавления нового пункта приёма
async function addPoint() {
  const Название = document.getElementById('name').value.trim(); // Убираем пробелы в начале и в конце
  const Адрес = document.getElementById('address').value.trim(); // Убираем пробелы в начале и в конце
  const msg = document.getElementById('message');

  // Проверка на пустые поля
  if (Название === "" || Адрес === "") {
    msg.textContent = '❌ Пожалуйста, заполните все поля';
    msg.style.color = 'red';
    return;
  }

  const res = await fetch('/api/points', {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ Название, Адрес, Широта: null, Долгота: null })
  });

  if (res.ok) {
    msg.textContent = '✅ Пункт добавлен!';
    msg.style.color = '#90ee90';
    loadPoints(); // Обновляем список пунктов
  } else {
    msg.textContent = '❌ Ошибка при добавлении';
    msg.style.color = 'red';
  }
}
document.addEventListener("DOMContentLoaded", function () {
  const sendBtn = document.querySelector('#chatModal button[onclick]');
  if (sendBtn) sendBtn.addEventListener('click', sendMessage);
});


async function loadPoints() {
  const res = await fetch('/api/points');
  const points = await res.json();
  const container = document.getElementById('points');
  container.innerHTML = '';  // Очищаем контейнер

  points.forEach(p => {
    const div = document.createElement('div');
    div.className = 'point';
    div.innerHTML = `<strong>${p.Название}</strong><br>${p.Адрес}`;
    container.appendChild(div);
  });
}
async function sendMessage() {
  const input = document.getElementById("userMessage");
  const chatBox = document.getElementById("chatBox");
  const message = input.value.trim();
  if (!message) return;

  chatBox.innerHTML += `<p><strong>Вы:</strong> ${message}</p>`;
  input.value = "";

  const res = await fetch("/api/chat", {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ message })
  });

  if (res.ok) {
    const data = await res.json();
    chatBox.innerHTML += `<p><strong>Бот:</strong> ${data.reply}</p>`;
    chatBox.scrollTop = chatBox.scrollHeight;
  } else {
    chatBox.innerHTML += `<p><strong>Бот:</strong> Ошибка ответа</p>`;
  }
}

// 👇 ЭТО ВАЖНО: экспортируем функцию в глобальный scope
window.sendMessage = sendMessage;



window.addReport = addReport;
window.openAddWasteTypeModal = openAddWasteTypeModal;
window.closeAddWasteTypeModal = closeAddWasteTypeModal;
window.saveNewWasteType = saveNewWasteType;

loadWasteTypes();

// Функция для загрузки всех отчётов
async function loadReports() {
  const res = await fetch('/api/reports');
  const reports = await res.json();
  const reportTable = document.getElementById('reportTable');
  reportTable.innerHTML = '';

  reports.forEach(r => {
    const row = document.createElement('tr');
    row.innerHTML = `
      <td>${r.ID}</td>
      <td>${r.Почта}</td>
      <td>${r.Тип_отхода}</td>
      <td>${r.Пункт}</td>
      <td>${r.Вес_в_кг}</td>
      <td>${r.Дата_сдачи.substring(0, 10)}</td>
    `;
    reportTable.appendChild(row);
  });
}

document.addEventListener('DOMContentLoaded', function () {
  loadReports();
  setInterval(loadReports, 5000);  // Обновляем отчёты каждые 5 секунд
});
