'use strict';

let taskListArray = [
    { 'id': 1, 'taskName': 'Netflixi kapat' },
    { 'id': 2, 'taskName': 'Pilavı unutma' },
    { 'id': 3, 'taskName': 'Mustafayı ara' },
    { 'id': 4, 'taskName': 'Raporu hazırla' },
    { 'id': 5, 'taskName': 'Kitap oku' }
];

const taskList = document.getElementById("task-list");
let liElement;
for (const task of taskListArray) {
    liElement = `
        <li class="list-group-item task">
            <div class="form-check">
                <input class="form-check-input" type="checkbox" value="" id="${task.id}">
                <label class="form-check-label" for="${task.id}">
                    ${task.taskName}
                </label>
            </div>
        </li>
    `;
    taskList.insertAdjacentHTML("beforeend", liElement);
}


// document.querySelector("#task-list").remove();
// document.querySelector("#task-list").children[2].remove();
// document.querySelector("#task-list").removeAttribute("class");
let result = document.querySelector("#task-list").children[1].getAttribute("class");
result = document.querySelector("#link").getAttribute("href");
result = document.querySelector("#link").getAttribute("target");

document.querySelector("#link").setAttribute("href", "https://www.haberturk.com");
document.querySelector("#link").innerText = "Haberturk";

document.querySelector("#task-list").classList.add("bg-danger");

result = document.querySelector("#task-list").classList;

document.querySelector("#task-list").classList.remove("bg-danger");
result = document.querySelector("#task-list").classList;

const h1 = document.querySelector("#header .col-6 h1");
if (h1.classList.contains("active-title")) {
    h1.classList.add("bg-danger");
} else {
    h1.classList.add("bg-success");
}

console.log(h1);