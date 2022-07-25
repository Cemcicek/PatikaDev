let userName = prompt("Kullanıcı bilginizi giriniz");
let info= document.querySelector('#myName');
info.innerHTML = `${userName}`;
let dates = ["Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"]

function showTime(params) {
    const today = new Date();
    let date=dates[today.getDay()];
    let h = today.getHours();
    let m = today.getMinutes();
    let s = today.getSeconds();
    m = checkTime(m);
    s = checkTime(s);

    document.getElementById('myClock').innerHTML = h + ":" + m + ":" + s + " " + date;
    setTimeout(showTime, 1000);
}

function checkTime(i) {
    if (i < 10) {i = "0" + i};
    return i;
}
showTime()