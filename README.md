# Order Delivery App

Простое веб-приложение для приемки заказов на доставку. Реализовано на ASP.NET Core MVC с использованием PostgreSQL в качестве базы данных.

## Технологии

- **Backend**: ASP.NET Core MVC
- **База данных**: PostgreSQL
- **ORM**: Entity Framework Core

## Требования

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- IDE (например, [Rider](https://www.jetbrains.com/rider/) или [Visual Studio](https://visualstudio.microsoft.com/))

## Установка и запуск

1. **Клонируйте репозиторий**
   ```bash
   git clone https://github.com/NailAbdulganiev/OrderDeliveryApp.git
   cd OlderDeliveryApp
2. **Установите необходимые NuGet-пакеты**
   В проекте используются следующие пакеты:
   Microsoft.EntityFrameworkCore
   Microsoft.EntityFrameworkCore.Design
   Npgsql.EntityFrameworkCore.PostgreSQL
   Установите их либо через NuGet Manager либо через терминал (перейдите в папку решения):
    ```bash
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCoreю.Design
   dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
3. **Настройте базу данных**
    Убедитесь, что PostgreSQL установлен и запущен.
    Создайте базу данных (например, Orders).
    Измените строку подключения в файле appsettings.json под ваши данные (ниже пример для стандартных настроек и БД Orders):
     "ConnectionStrings": {
      "ConnectionToOrdersDb": "Host=localhost;Port=5432;Database=Orders;Username=postgres;Password=ваш-пароль"
    }
   Либо под вашего пользователя и БД:
   "ConnectionStrings": {
      "ConnectionToOrdersDb": "Host=localhost;Database=ваша-бд;Username=ваш-username;Password=ваш-пароль"
    }
5. **Примените миграции**
   Выполните команду для создания миграций и примените миграции к БД:
     ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
6. **Запустите приложение**
     ```bash
     dotnet run
## Функционал
- **Создание заказа**
    Форма для ввода данных о заказе (город отправителя, адрес отправителя, город получателя, адрес получателя, вес груза, дата забора груза).
- **Список заказов**
  Отображение всех созданных заказов с автоматически сгенерированным номером заказа.
- **Детали заказа**
  Просмотр деталей заказа в режиме чтения (открывается при клике на заказ в списке).
## Структура проекта
- Модели: Order.cs — модель заказа.
- Контроллеры: OrderController.cs — обработка запросов, связанных с заказами.
- Контекст базы данных: AppDbContext.cs — для работы с базой данных.
- Представления: Views/Order
  - Create - для создания нового заказа.
  - Details - для полной информации о конкретном заказе.
  - Index - страница со списком всех заказов.
- wwwroot. Папка с необходимыми библиотеками (bootstrap, jQuery)
- Миграции: Автоматически создаются при использовании Entity Framework Core.
