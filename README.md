# Employee System

Учебный проект на C#. Система сотрудников компании с иерархией классов.

## Что используется
- Интерфейсы `IWorker`, `IPayable`, `IManageable`
- Абстрактный класс `Employee`
- Наследование: `Developer`, `Designer`, `Intern`
- Полиморфизм: массив `Employee[]`, вызов `Work()` без знания конкретного типа
- Паттерн `as` для проверки реализации `IPayable`
- Статический счётчик сотрудников

## Как запустить
1. Склонировать репозиторий
2. `dotnet run`

## Темы
`interface` `abstract class` `inheritance` `polymorphism` `as pattern` `static`
