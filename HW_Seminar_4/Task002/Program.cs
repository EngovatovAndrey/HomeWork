/* Задача 27: Напишите программу, реализующую метод, который принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using static System.Console;
Clear();

WriteLine("Введите число");
int UserNumber = Convert.ToInt32(ReadLine());
WriteLine($"Сумма цифр введеного числа = {DigitSum(UserNumber)}");

int DigitSum (int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}