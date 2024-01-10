// let age = 7;
// if (age>=18) {
//     console.log("Reşitsiniz");
// }else{
//     console.log("Reşit değilsiniz");
// }

// let color = "green";
// if (color == "red") {
//     console.log("Kırmızı güzeldir");
// } else if (color == "green") {
//     console.log("Yeşil iyidir");
// } else {
//     console.log("Kırmızı ve yeşil dışındaki renkler, idare eder");
// };

// let age=null;

// if(age===30){
//     console.log("Tamamdır");
// }else if(age===undefined){
//     console.log("Lütfen yönetime başvurunuz");
// }else if(age===null) {
//     console.log("Boş bırakmayınız")
// }else {
//     console.log("Yarın gelebilirsiniz.")
// }

// let x = 325;
// switch (x) {
//     case 3:
//         console.log("Üç");
//         break;
//     case 5:
//         console.log("Beş");
//         break;
//     case 7:
//         console.log("Yedi");
//     default:
//         console.log("Hiçbiri");
//         break;
// }

let ay = "Temmuz";
let mevsim;

switch (true) {
    case ["Aralık","Ocak","Şubat"].includes(ay):
        mevsim="Kış";
        break;
    case ["Mart","Nisan","Mayıs"].includes(ay):
        mevsim="İlkbahar";
        break;
    case ["Haziran", "Temmuz", "Ağustos"].includes(ay):
        mevsim = "Yaz";
        break;
    case ["Eylül", "Ekim", "Kasım"].includes(ay):
        mevsim = "Sonbahar";
        break;
}
console.log(mevsim);