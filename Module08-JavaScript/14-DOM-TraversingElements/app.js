let result;
const taskList = document.getElementById("task-list");

result = taskList.children;
result = taskList.children[0];
result = taskList.firstElementChild;
result = taskList.lastElementChild;

result = document.getElementById("header");
result = result.parentElement;

result = document.querySelector(".task");
result = result.nextElementSibling.nextElementSibling;
result = result.previousElementSibling.previousElementSibling.previousElementSibling;
console.log(result);