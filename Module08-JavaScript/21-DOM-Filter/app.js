'use strict';
const taskList = document.getElementById("task-list");
const taskInput = document.getElementById("task-input");
const btnAddTask = document.getElementById("btn-add-task");
const btnClearAll = document.getElementById("btn-clear-all");
const filters = document.getElementById("filters")
let isEditMode = false;
let editedTaskId;

let taskListArray = [
    { 'id': 1, 'taskName': 'Netflixi kapat', 'completed': true },
    { 'id': 2, 'taskName': 'Pilavı unutma', 'completed': false },
    { 'id': 3, 'taskName': 'Mustafayı ara', 'completed': false },
    { 'id': 4, 'taskName': 'Raporu hazırla', 'completed': false },
    { 'id': 5, 'taskName': 'Kitap oku', 'completed': true }
];

btnAddTask.addEventListener("click", addTask);

function addTask(e) {
    e.preventDefault();
    const value = taskInput.value.trim();
    if (value == '') {
        alert("Lütfen görev adını boş bırakmayınız!");
    } else {
        if (isEditMode = true) //kayıt güncelleme
        {
            for (const task of taskListArray) {
                if (task.id == editedTaskId) {
                    task.taskName = taskInput.value;
                    isEditMode = false;
                    btnAddTask.innerText = "Ekle";
                    btnAddTask.classList.remove("btn-warning");
                }
            }
        }
        else //yeni kayıt
        {
            const id = taskListArray[taskListArray.length - 1].id + 1;
            const newTask = { 'id': id, 'taskName': value }
            taskListArray.push(newTask);
        }


        taskInput.value = "";
        taskInput.focus();
        displayTasks(filterMode);
    }
}

btnClearAll.addEventListener("click", clearAll);

function clearAll() {
    let answer = confirm('Tüm Görevler Silinecek!');
    if (answer) {
        taskListArray = [];
        displayTasks(filterMode);
    }

}

for (const span of filters) {
    span.addEventListener("click", function () {
        document.querySelector("span.active").classList.remove("active");
        span.classList.add("active");
    })
}

function displayTasks(filterMode) {
    taskList.innerHTML = "";
    let liElement;
    for (const task of taskListArray) {
        liElement = `
        <li class="list-group-item task d-flex">
            <div class="form-check align-items-center d-flex gap-1">
                <input onclick="updateStatus(${task.id});" class="form-check-input" type="checkbox" value="" id="${task.id}" ${task.completed ? 'checked' : ''}>
                <label class="form-check-label ${task.completed ? 'text-decoration-line-through' : ''}" for="${task.id}" >
                    ${task.taskName}
                </label>
            </div>
            <div class="btn-group ms-auto" role="group" aria-label="Basic example">
                <button onclick="editTask(${task.id},'${task.taskName}');" type="button" class="btn btn-warning">Düzelt</button>
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
    displayTasks(filterMode);
}

function editTask(id, taskName) {
    editedTaskId = id;
    isEditMode = true;
    taskInput.value = taskName;
    taskInput.focus();
    btnAddTask.innerText = "Güncelle";
    btnAddTask.classList.add("btn-warning");
}

function updateStatus(id) {
    for (let i = 0; i < taskListArray.length; i++) {
        if (taskListArray[i].id == id) {
            taskListArray[i].completed = !taskListArray[i].completed;
            break;
        }
    }
    displayTasks(filterMode);
}

displayTasks(filterMode);

