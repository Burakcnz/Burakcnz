'use strict';
const taskList = document.getElementById("task-list");
const taskInput = document.getElementById("task-input");
const btnAddTask = document.getElementById("btn-add-task");

let taskListArray = [
    { 'id': 1, 'taskName': 'Netflixi kapat' },
    { 'id': 2, 'taskName': 'Pilavı unutma' },
    { 'id': 3, 'taskName': 'Mustafayı ara' },
    { 'id': 4, 'taskName': 'Raporu hazırla' },
    { 'id': 5, 'taskName': 'Kitap oku' }
];

// btnAddTask.addEventListener("click", function(e){
//     e.preventDefault();
//     console.log("Tıklandı");
// });

btnAddTask.addEventListener("click", addTask);

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

function addTask(e) {
    e.preventDefault();
    console.log("Tıklandı");
}