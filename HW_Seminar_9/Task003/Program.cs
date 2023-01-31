/* Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

using static System.Console;
Clear();

WriteLine("Введите два не отрицательный числа, N и M, через пробел");
string[] param = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(AkkermanMethod(Convert.ToInt32(param[0]), Convert.ToInt32(param[1])));

int AkkermanMethod (int n, int m)
{
    if(n==0) return m+1;
    if(n != 0 && m==0) return AkkermanMethod(n-1, 1);
    else return AkkermanMethod(n-1, AkkermanMethod(n, m-1));
}