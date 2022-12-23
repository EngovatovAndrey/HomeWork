// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

using static System.Console;
Clear();

WriteLine("Введите число - ");
int number = Convert.ToInt32(ReadLine());
int n = number;

while (Math.Abs(n) > 999)
{
    n /= 10;
}
    
WriteLine(Math.Abs(number) < 100? "Третьей цифры нет": $"{n % 10}");   