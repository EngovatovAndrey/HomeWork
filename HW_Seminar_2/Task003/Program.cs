﻿// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
using static System.Console;
Clear();

WriteLine("Введите цифру от 1 до 7");
int number = Convert.ToInt32(ReadLine());
string []week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", 
"Суббота", "Воскресение"};

WriteLine(number > 7? "Введено не корректное число!":number == 6? $"{week[number-1]} - Выходной!": 
        number == 7? $"{week[number-1]} - Выходной!":
        $"{week[number-1]} - Не выходной");
