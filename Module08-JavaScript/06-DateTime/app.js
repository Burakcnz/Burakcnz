let result;
let now = new Date();

result = now;
result = now.getDate();
result = now.getDay();
result = now.getFullYear();

let birthDay = new Date(1975, 6, 20);

result = birthDay;
result = birthDay.getDay();

birthDay.setFullYear(1985);
birthDay.setDate(21);
birthDay.setMonth(0);
result = birthDay;






console.log(result);