# API-Services
Серверная часть приложения решающая небольшую бизнес логику: хранение информации о балансе и переводах в криптовалютах.

Серверная часть: REST API Net core 7 – слой API с описанием функций (swagger)


***Api***

URL : https://localhost:44333/api/Home

Для получения данных о пользователе и взаимодействие с данными: просмотр, добавление, редактирование, удаление


URL : https://localhost:44333/api/Archivs 

Для получения архива действия клиента

![Scren](https://github.com/Lifanov1996/API-Services/blob/main/Api-1.png)


***База данных***

Используеться файловая `база данных SQLite`. База данных состоит из 3 таблиц (Clients, Wallets и Archivs). Для работы подключен библиотека EF Core
```
builder.Services.AddDbContext<ClientDbContext>(options =>
                  options.UseSqlite(connectionString));
```

Инициализировалась БД с [начальными данными](https://github.com/Lifanov1996/API-Services/blob/main/Web-Api/DataBase/ClientDbContext.cs) 
```
ADD-MIGRATION Init
UPDATE- DATABASE
```

***Cors***

Чтобы избежать проблеммы с подключение к API c других источников, хостов и путей используеться сервис 
```
builder.Services.AddCors();
app.UseCors(builder => builder.AllowAnyOrigin());
```
Для доступа всех источников к API

