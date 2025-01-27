document.addEventListener("DOMContentLoaded", () => {
    // Убираем скрытие содержимого и добавляем fade-in
    setTimeout(() => {
        document.body.classList.add("fade-in");
    }, 100); // Задержка 100 мс для корректной анимации

    // Работа с модальным окном
    const callButton = document.getElementById("callButton");
    const callModal = document.getElementById("callModal");
    const modalContent = document.querySelector(".modal-content");
    const close = document.querySelector(".close");
    const copyButton = document.getElementById("copyButton");

    // Открытие модального окна
    if (callButton) {
        callButton.addEventListener("click", () => {
            callModal.classList.add("show");
        });
    }

    // Закрытие модального окна по кнопке "Закрыть"
    if (close) {
        close.addEventListener("click", () => {
            callModal.classList.remove("show");
        });
    }

    // Закрытие модального окна при клике за его пределами
    if (callModal) {
        callModal.addEventListener("click", (event) => {
            if (!modalContent.contains(event.target)) {
                callModal.classList.remove("show");
            }
        });
    }

    // Копирование номера телефона в буфер обмена
    if (copyButton) {
        copyButton.addEventListener("click", () => {
            navigator.clipboard.writeText("+7 (123) 456-78-90").then(() => {
                alert("Номер скопирован в буфер обмена!");
            });
        });
    }

    // Переход между страницами с эффектом fade-out
    const links = document.querySelectorAll("a");
    links.forEach(link => {
        link.addEventListener("click", (event) => {
            event.preventDefault(); // Останавливаем стандартное действие по переходу

            // Добавляем эффект fade-out перед переходом
            document.body.classList.add("fade-out");

            // Переход на новую страницу после завершения анимации
            setTimeout(() => {
                window.location.href = link.href;
            }, 1000); // Задержка в миллисекундах
        });
    });
});
