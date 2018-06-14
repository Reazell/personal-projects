document.addEventListener('DOMContentLoaded', start);
let button;
let input;
let body;
let canvas;
let context;
let textarea;
let infoDiv;
let whileArray = ['raz', 'dwa', 'trzy', 'cztery', 'pięć'];

// rozne
function start() {
    button = document.getElementById('apply');
    input = document.getElementById('input')
    body = document.getElementsByTagName('body')[0];
    canvas = document.getElementById('canvas');
    textarea = document.getElementById('area');
    info = document.getElementById('info');
    context = canvas.getContext('2d');
    context.fillStyle="red";
    context.fillRect(10, 10, 50, 50);
    context.stroke();
    button.addEventListener('click', applyColor);
    textarea.addEventListener('keyup', countLetters);
    textarea.addEventListener('keydown', countLetters);
    pracownik.obliczWynagrodzenie(200);
    iterateArray(whileArray);
}

// zadanie 1
function applyColor() {
    const value = input.value;
    body.style.backgroundColor = value;
    }

// zadanie 2
function iterateArray() {
    let i = 1;
    whileArray.forEach(el => {
        const string = 'h' + i;
        const header = document.createElement(string);
        body.appendChild(header);
        const rgb = 'rgb(' + randomNumber().toString() + ',' + randomNumber().toString() + ',' + randomNumber().toString() + ')';
        header.style.backgroundColor = rgb;
        header.style.height = '30px';
        header.innerHTML = el;
        i++;
    });
}
function randomNumber() {
    return Math.floor(Math.random() * (256 - 1 + 1)) + 1
};

// zadanie 3
var myMap = new Map();
myMap.set(0, 'zero');
myMap.set(1, 'one');
myMap.set(2, 'two');
myMap.set(3, 'three');
for (var [key, value] of myMap) {
      console.log(key + ' = ' + value);
}

// zadanie 4
class Pracownik {
    constructor(imie, nazwisko, stanowisko, stawka, wynagrodzenie) {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.stanowisko = stanowisko;
        this.stawka = stawka;
        this.wynagrodzenie = wynagrodzenie;
    }
    obliczWynagrodzenie(iloscGodzin) {
        console.log('Stawka ' + this.stawka);
        console.log('Ilosc godzin ' +  iloscGodzin);
        console.log('Wyplata wynosi ' + this.stawka * iloscGodzin);
    }
}

const pracownik = new Pracownik('Jan', 'Kowalski', 'Nauczyciel', 14, 1500);

// zadanie 5 - w roznych

// zadanie 6
function countLetters() {
    if (textarea.value.length >= 30) {
        info.innerHTML =info.innerHTML = textarea.value.length + '    napisales 30 lub więcej znaków';
    }
    else {
        info.innerHTML = textarea.value.length;    
    }
}