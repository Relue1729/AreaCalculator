# AreaCalculator
Тестовое задание

Единственный не до конца понятный мне момент был косаемо пункта "Легкость добавления других фигур". Я рассматривал идею написания Generic метода что принимал бы Func с формулой для вычисления площади с произвольными аргументами, но подумал над этим десять секунд и стало очевидным что вызов подобного метода будет длиннее чем просто добавить новый обьект фигуры с уже заданным методом вычисления площади. Тк формулы для вычисления площадей разных фигур все разные и их не свести к единому знаменателю, по крайней мере я не знаю как, звучит достаточно бессмысленно. На данный момент можно просто добавить класс что наследует от IShape и все.

Валидация треугольника целиком происходит только из конструктора, и не при вызове сеттеров, чтобы не было внезапных исключений при манипуляцях сторон треугольника из внешнего кода (Метод Triangle.IsValid())




SQL запрос по второй задаче лежит в ProductCategoryName.sql, корневая директория проекта.





Оригинальный текст задания:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

-Юнит-тесты

-Легкость добавления других фигур

-Вычисление площади фигуры без знания типа фигуры в compile-time

-Проверку на то, является ли треугольник прямоугольным


Второе задание:

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

