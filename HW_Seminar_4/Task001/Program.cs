﻿/* При решении задач обязательным условием является реализация методов
Задача 25: Напишите программу, реализующую метод,который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
В задаче не использвать стандартный метод Pow!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using static System.Console;
Clear();

WriteLine("Введите число A");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите число B");
int number2 = Convert.ToInt32(ReadLine());

WriteLine($"Результат работы метода - {DigitPower(number1, number2)}");

int DigitPower(int a, int b)
{
    int result = 1;
    while (b > 0)
    {
        result *= a;
        b -=1;
    }
    return result;
}