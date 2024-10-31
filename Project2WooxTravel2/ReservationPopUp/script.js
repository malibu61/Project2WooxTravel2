//document.getElementById('openPopup').onclick = function () {
//    document.getElementById('reservationPopup').style.display = 'flex';
//}

//document.getElementById('closePopup').onclick = function () {
//    document.getElementById('reservationPopup').style.display = 'none';
//}

//window.onclick = function (event) {
//    if (event.target == document.getElementById('reservationPopup')) {
//        document.getElementById('reservationPopup').style.display = 'none';
//    }
//}

//document.getElementById('reservationForm').onsubmit = function (e) {
//    e.preventDefault(); // Formun gönderilmesini durdur

//    const day = document.getElementById('day').value;
//    const month = document.getElementById('month').value;
//    const year = document.getElementById('year').value;

//    if (!day || !month || !year) {
//        alert('Lütfen tüm tarih alanlarını doldurun.');
//        return;
//    }

//    // Burada form verilerini işleyebilirsiniz
//    alert(`Rezervasyon oluşturuldu! Tarih: ${day}/${month}/${year}`);

//    // Formu kapat
//    document.getElementById('reservationPopup').style.display = 'none';
//}

window.onload = function () {
    document.getElementById('reservationPopup').style.display = 'flex';
};

document.getElementById('closePopup').onclick = function () {
    document.getElementById('reservationPopup').style.display = 'none';
}

window.onclick = function (event) {
    if (event.target == document.getElementById('reservationPopup')) {
        document.getElementById('reservationPopup').style.display = 'none';
    }
}

document.getElementById('reservationForm').onsubmit = function (e) {
    e.preventDefault(); // Formun gönderilmesini durdur

    const day = document.getElementById('day').value;
    const month = document.getElementById('month').value;
    const year = document.getElementById('year').value;

    if (!day || !month || !year) {
        alert('Lütfen tüm tarih alanlarını doldurun.');
        return;
    }

    alert(`Rezervasyon oluşturuldu! Tarih: ${day}/${month}/${year}`);
    document.getElementById('reservationPopup').style.display = 'none';
}
