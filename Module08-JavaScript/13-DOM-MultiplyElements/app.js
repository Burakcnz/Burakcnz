let result;

result = document.getElementsByClassName("card-header");
result = document.getElementsByClassName("task");
result = document.getElementsByClassName("task")[2].innerText;
result = document.getElementsByClassName("task");
// for (let i = 0; i < result.length; i++) {
//     // console.log(result[i].innerText);
//     if (i % 2 != 0) {
//         result[i].style.color = "red";
//     }
// }
// console.log(result);

for (const task of result) {
    task.style.color = "blue";
    task.style.fontSize = "30px";
    task.innerText = "Item";
}

result = document.querySelectorAll(".task");
for (const task of result) {
    task.style.backgroundColor = 'navy';
    task.style.color = 'white';
}
console.log(result);
