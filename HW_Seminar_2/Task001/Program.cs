// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();

WriteLine("Введите трехзначное число - ");
int number = Convert.ToInt32(ReadLine());
int digit = (number / 10)% 10;

    
WriteLine(Math.Abs(number) > 999 || Math.Abs(number) < 100?     // Проверка является ли число трехзначным
     "Вы ввели не трехзначное число": $"{Math.Abs(digit)}");   // Добавил метод Math.Abs, чтобы число не вводилось со знаком минус, если такое введут
