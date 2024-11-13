// script.js
let currentPage = 1; 
const flightsPerPage = 5; // Количество полетов на странице 
 
function searchFlights() { 
    const dateInput = document.getElementById('dateInput').value; 

    const toSelect = document.getElementById('toSelect').value; 

    // Для примера, данные о перелетах будут взяты из фиктивного объекта
    const flightsData = [
        { flight: 'SU123', from: 'Москва', to: 'Санкт-Петербург', departureDate: '2024-05-15', departureTime: '10:00', arrivalTime: '12:00' },
        { flight: 'SU456', from: 'Москва', to: 'Екатеринбург', departureDate: '2024-05-15', departureTime: '14:00', arrivalTime: '17:00' },
        { flight: 'SU789', from: 'Москва', to: 'Краснодар', departureDate: '2024-05-16', departureTime: '08:00', arrivalTime: '10:30' },
        { flight: 'SU012', from: 'Москва', to: 'Кемерово', departureDate: '2024-05-16', departureTime: '11:30', arrivalTime: '14:30' },
        { flight: 'SU345', from: 'Москва', to: 'Волгоград', departureDate: '2024-05-15', departureTime: '16:00', arrivalTime: '18:00' },
        { flight: 'SU678', from: 'Москва', to: 'Сочи', departureDate: '2024-05-15', departureTime: '09:30', arrivalTime: '11:30' },
        { flight: 'SU901', from: 'Москва', to: 'Новосибирск', departureDate: '2024-05-15', departureTime: '12:00', arrivalTime: '17:00' },
        { flight: 'SU234', from: 'Москва', to: 'Омск', departureDate: '2024-05-16', departureTime: '08:30', arrivalTime: '09:30' },
        { flight: 'SU567', from: 'Москва', to: 'Улан-Удэ', departureDate: '2024-05-15', departureTime: '10:00', arrivalTime: '17:00' },
        { flight: 'SU890', from: 'Москва', to: 'Уфа', departureDate: '2024-05-17', departureTime: '13:00', arrivalTime: '15:00' },
        { flight: 'SU123', from: 'Москва', to: 'Омск', departureDate: '2024-05-15', departureTime: '15:30', arrivalTime: '16:30' },
        { flight: 'SU456', from: 'Москва', to: 'Пермь', departureDate: '2024-05-15', departureTime: '17:00', arrivalTime: '18:30' },
        { flight: 'SU789', from: 'Москва', to: 'Омск', departureDate: '2024-05-17', departureTime: '18:00', arrivalTime: '20:00' },
        { flight: 'SU012', from: 'Москва', to: 'Омск', departureDate: '2024-05-15', departureTime: '07:30', arrivalTime: '08:30' },
        { flight: 'SU345', from: 'Москва', to: 'Улан-Удэ', departureDate: '2024-05-18', departureTime: '09:00', arrivalTime: '10:30' },
        { flight: 'SU678', from: 'Москва', to: 'Кемерово', departureDate: '2024-05-15', departureTime: '11:30', arrivalTime: '13:00' },
        { flight: 'SU901', from: 'Москва', to: 'Воронеж', departureDate: '2024-05-15', departureTime: '14:00', arrivalTime: '15:30' },
        { flight: 'SU234', from: 'Москва', to: 'Пермь', departureDate: '2024-05-18', departureTime: '16:30', arrivalTime: '18:00' },
        { flight: 'SU567', from: 'Москва', to: 'Улан-Удэ', departureDate: '2024-05-15', departureTime: '08:00', arrivalTime: '10:00' },
        { flight: 'SU890', from: 'Москва', to: 'Томск', departureDate: '2024-05-15', departureTime: '10:30', arrivalTime: '12:30' },
        { flight: 'SU123', from: 'Москва', to: 'Воронеж', departureDate: '2024-05-16', departureTime: '13:00', arrivalTime: '15:30' },
        { flight: 'SU456', from: 'Москва', to: 'Пермь', departureDate: '2024-05-15', departureTime: '16:00', arrivalTime: '19:00' },
        { flight: 'SU789', from: 'Москва', to: 'Воронеж', departureDate: '2024-05-16', departureTime: '07:00', arrivalTime: '10:00' },
        { flight: 'SU012', from: 'Москва', to: 'Кемерово', departureDate: '2024-05-15', departureTime: '11:00', arrivalTime: '13:00' },
        { flight: 'SU345', from: 'Москва', to: 'Томск', departureDate: '2024-05-15', departureTime: '14:30', arrivalTime: '15:30' },
        { flight: 'SU678', from: 'Москва', to: 'Владивосток', departureDate: '2024-05-15', departureTime: '16:00', arrivalTime: '20:00' },
        { flight: 'SU901', from: 'Москва', to: 'Томск', departureDate: '2024-05-15', departureTime: '08:30', arrivalTime: '12:30' },
        { flight: 'SU234', from: 'Москва', to: 'Магадан', departureDate: '2024-05-15', departureTime: '13:00', arrivalTime: '17:00' },
        { flight: 'SU567', from: 'Москва', to: 'Владивосток', departureDate: '2024-05-15', departureTime: '18:00', arrivalTime: '21:00' },
        { flight: 'SU890', from: 'Москва', to: 'Петропавловск-Камчатский', departureDate: '2024-05-15', departureTime: '10:00', arrivalTime: '14:00' },
        { flight: 'SU123', from: 'Москва', to: 'Магадан', departureDate: '2024-05-15', departureTime: '15:30', arrivalTime: '18:30' }
    ];

     let filteredFlights; 
 
    if (toSelect === 'all') { 
        filteredFlights = flightsData.filter(flight => flight.departureDate === dateInput); 
    } else if (toSelect !== 'all') { 
        filteredFlights = flightsData.filter(flight => flight.to === toSelect && flight.departureDate === dateInput); 
    }

    const totalPages = Math.ceil(filteredFlights.length / flightsPerPage); 
    displayFlights(filteredFlights.slice((currentPage - 1) * flightsPerPage, currentPage * flightsPerPage)); 
    updatePaginationUI(currentPage, totalPages); 
}

function displayFlights(flights) {
    const tableBody = document.querySelector('#flightTable tbody');
    tableBody.innerHTML = '';

    flights.forEach(flight => {
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${flight.flight}</td>
            <td>${flight.from}</td>
            <td>${flight.to}</td>
            <td>${flight.departureDate}</td>
            <td>${flight.departureTime}</td>
            <td>${flight.arrivalTime}</td>
        `;
        tableBody.appendChild(row);
    });
}



function updatePaginationUI(currentPage, totalPages) {
    const paginationInfo = document.getElementById('paginationInfo');
    paginationInfo.textContent = `Page ${currentPage} of ${totalPages}`;
}

function goToPreviousPage() {
    if (currentPage > 1) {
        currentPage--;
        searchFlights();
    }
}

function openAboutModal() {
  document.getElementById("aboutModal").style.display = "block";
}

// Открыть модальное окно "О нас"
function openAboutModal() {
  document.getElementById("aboutModal").style.display = "block";
}

// Закрыть модальное окно "О нас"
function closeAboutModal() {
  document.getElementById("aboutModal").style.display = "none";
}

// Закрыть модальное окно "О нас", если пользователь щелкает вне его
window.onclick = function(event) {
  var modal = document.getElementById("aboutModal");
  if (event.target == modal) {
    modal.style.display = "none";
  }
}

function goToNextPage() {
    const totalPages = parseInt(document.getElementById('paginationInfo').textContent.split(' ')[3]);
    if (currentPage < totalPages) {
        currentPage++;
        searchFlights();
    }
}
