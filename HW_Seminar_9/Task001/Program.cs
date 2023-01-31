/* Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел 
в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using static System.Console;
Clear();

WriteLine("Задайте число, N");
int userNumber = Convert.ToInt32(ReadLine()!);
WriteLine(PrintNumbersRec(userNumber));

string PrintNumbersRec (int n)
{
    return n == 1? n.ToString(): $"{n}, {PrintNumbersRec (n -1)}";
}

