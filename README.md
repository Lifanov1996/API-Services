# API-Services
Серверная часть приложения решающая небольшую бизнес логику: хранение информации о балансе и переводах в криптовалютах.

Серверная часть: REST API Net core 7 – слой API с описанием функций (swagger)

***Api***
URL : https://localhost:44333/api/Home

Для получения данных о пользователе и взаимодействие с данными: просмотр, добавление, редактирование, удаление


URL : https://localhost:44333/api/Archivs 

Для получения архива действия 

***База данных***

Используеться файловая `база данных SQLite`. База данных состоит из 3 таблиц (Clients, Wallets и Archivs). Для работы подключен сервис DbContext 
```
builder.Services.AddDbContext<ClientDbContext>(options =>
                  options.UseSqlite(connectionString));
```

Инициализировалась БД с начальными данными 
```
ADD-MIGRATION Init
UPDATE- DATABASE
```

