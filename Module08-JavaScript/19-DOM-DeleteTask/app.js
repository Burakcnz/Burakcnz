'use strict';
const taskList = document.getElementById("task-list");
const taskInput = document.getElementById("task-input");
const btnAddTask = document.getElementById("btn-add-task");
const btnClearAll = document.getElementById("btn-clear-all");

let isEditMode=false;

let taskListArray = [
    { 'id': 1, 'taskName': 'Netflixi kapat' },
    { 'id': 2, 'taskName': 'Pilavı unutma' },
    { 'id': 3, 'taskName': 'Mustafayı ara' },
    { 'id': 4, 'taskName': 'Raporu hazırla' },
    { 'id': 5, 'taskName': 'Kitap oku' }
];

btnAddTask.addEventListener("click", addTask);

function addTask(e) {
    e.preventDefault();
    const value = taskInput.value.trim();
    if (value == '') {
        alert("Lütfen görev adını boş bırakmayınız!");
    } else {
        const id = taskListArray[taskListArray.length - 1].id + 1;
        const newTask = { 'id': id, 'taskName': value }
        taskListArray.push(newTask);
        taskInput.value = "";
        taskInput.focus();
        displayTasks();
        console.log(taskListArray);
    }
}

btnClearAll.addEventListener("click", clearAll);

function clearAll(){
    let answer=confirm('Tüm Görevler Silinecek!');
    if(answer){
        taskListArray=[];
        displayTasks();
    }

}

function displayTasks() {
    taskList.innerHTML = "";
    let liElement;
    for (const task of taskListArray) {
        liElement = `
        <li class="list-group-item task d-flex">
            <div class="form-check align-items-center d-flex gap-1">
                <input class="form-check-input" type="checkbox" value="" id="${task.id}">
                <label class="form-check-label" for="${task.id}">
                    ${task.taskName}
                </label>
            </div>
            <div class="btn-group ms-auto" role="group" aria-label="Basic example">
                <button type="button" class="btn btn-warning">Düzelt</button>
                <button onclick="deleteTask(${task.id});" type="button" class="btn btn-danger">Sil</button>
            </div>
        </li>
    `;
        taskList.insertAdjacentHTML("beforeend", liElement);
    }
}

function deleteTask(id) {
    let deletedIndex;
    for (const taskIndex in taskListArray) {
        if (taskListArray[taskIndex].id == id) {
            deletedIndex = taskIndex;
            break;
        }
    }
    taskListArray.splice(deletedIndex, 1);
    displayTasks();
}

displayTasks();

