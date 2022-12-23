// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
Clear();

WriteLine("Введите число");
int n = Convert.ToInt32(ReadLine());
int x = 1;

while (x < n+1)
{
    Write($"{Math.Pow(x, 3)}, ");
    x +=1;
}

//Write(Math.Pow(n, 3));