// express — фреймворк для создания веб-приложений
const express = require("express");

// создаём express-приложение
const app = express();
// оно будет работать на определенном порту компьютера
const port = 3000;
const path = "B:Programmingcodewarsindex.js";
// если отправить GET-запрос на /, то получим ответ "Hello World!"
app.get("/", (req, res) => {
  res.send(path);
});

// запускаем приложние
app.listen(port, () => {
  console.log(`Приложение запущено на http://localhost:${port}`);
});
