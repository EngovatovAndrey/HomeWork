/*
Задача 66: Напишите программу, которая реализует рекурсивный метод 
нахождения суммы натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;
Clear();

WriteLine("Задайте число, M и N, через пробел");
string[] param = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// WriteLine(sumRec(Convert.ToInt32(param[0]), Convert.ToInt32(param[1])));
WriteLine(NumbersSumRec(Convert.ToInt32(param[0]), Convert.ToInt32(param[1])));

int sumRec(int m, int n)
{
    if(m== n-1) return 0;
    else return m + sumRec(m-1, n);
}

int sumRecUP(int m, int n)
{
    if(m== n+1) return 0;
    else return m + sumRecUP(m+1, n);
}

int NumbersSumRec(int m, int n)
{
        if (m > n)
        {
            // if (m == n-1) return 0;
            // return m + NumbersSumRec(m-1, n);
            return sumRec(m, n);
        }

        if (m < n)
        {
            // if(m== n+1) return 0;
            // else return m + NumbersSumRec(m+1, n);
            return sumRecUP(m, n);
        }

        else return m;
}


