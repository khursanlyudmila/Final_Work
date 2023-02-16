# **Итоговая проверочная работа**

 Данная работа представлена для проверки знаний и навыков по итогу прохождения первого блока обучения по программе "Разработчик".

### ***Итоговая работа призвана проверить:***
* навыки работы с репозиторием, в том числе с удаленным, на примере GitHub;
* умение рисовать блок-схемы алгоритмов;
* умение программировать на языке С# в рамках изученного учебного материала.

**Для проверки знаний в части программирования, предлагается решить следующую задачу:**
написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна трем символам.

**Предлагается следующее решение задачи:**

1. Предложено пользователю ввести текст с консоли.
2. У введенного текста будет метод Split, позволяющий сделать разбивку с учётом символа - разделителя (в нашем случае - "пробела".
3. Инициализируем первый массив на основе введенного пользователем текста.
4. Инициализируем второй массив, равный длинне первого.
5. Инициализируем вспомогательную переменную count = 0, в которую запишем количество строк, длина которых 3 символа и меньше.
6. Вычисляем количество строк, длинна которых меньше либо равна 3 символа.
##### *В цикле проходим по каждой строке массива. На каждой итерации сверяем длину строки - если длина меньше или равна трём, то увеличиваем ранее инициализируемую переменную count и увеличиваем счётчик цикла. Если длина больше трёх увеличиваем только счётчик цикла.* #####
7. Заполняем второй массив строками из первого массива с учетом условия и результатом его проверки.
8. Выводим второй массив на экран или сообщение о том, что массив не имееет в себе элементов, удовлетворяющих условию.

### Графическое представление метода в папке Scheme. ###

### Реализация алгоритма по пути Task/Program.cs ###
