// let yariCap = 14;
// const piSayisi = 3.14;
// console.log("Yarıçap", yariCap, typeof yariCap);
// console.log("Pi", piSayisi, typeof piSayisi);

// let alan = piSayisi * yariCap ** 2;
// console.log(alan);

// console.log(15 / 4);
// console.log(14 % 2);

// let sayi1 = 4.8689;
// console.log(Math.trunc(sayi1));

// console.log(Math.floor(sayi1));
// console.log(Math.ceil(sayi1));
// console.log(Math.round(sayi1));

let result;

result = Number("40.5a");
result = parseInt("10.8");
result = parseInt("10a.5abc");
result = parseInt("abc10");
result = parseInt("    456jıou");
result = parseFloat("10.8");
result = parseFloat("10.8.9");

let number = 15.6793;
result = number.toFixed(2);
result = number.toPrecision(4);

result = Math.pow(5, 3);
result = Math.pow(4, 2);
result = Math.sqrt(25);
result = Math.abs(-7);
result = Math.min(46, 34, 133, 89);
result = Math.max(46, 34, 133, 89);

result = Math.random();
result = parseInt(Math.random() * 10) + 1;
console.log(result);