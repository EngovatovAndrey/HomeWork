/* Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, 
и возвращающий значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1;7 -> такого элемента в массиве нет
1;1 -> 9
*/

using static System.Console;
Clear();
int[,] matrix = GetMatrix(3, 4);
WriteLine("Укажите позицию элемента введя через пробел два числа");
string[] UserNumbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintMatrix(matrix);
WriteLine(SearchMatrix(matrix, Convert.ToInt32(UserNumbers[0]), Convert.ToInt32(UserNumbers[1])));

int[,] GetMatrix (int a, int b)
{
    int[,] matrix = new int[a,b];
    for(int i = 0; i < a;i++)
    {
        for(int j = 0; j < b;j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix (int[,] mtx)
{
    WriteLine("Заданный двумерный массив");
    for(int i = 0; i < mtx.GetLength(0);i++)
    {
        for(int j = 0; j < mtx.GetLength(1);j++)
        {
            Write($"{mtx[i, j]} ");
        }
        WriteLine();
        WriteLine();
    }
}
string SearchMatrix(int[,] mtx, int index0, int index1)
{
    string no = "такого элемента в массиве нет";
    if(index0 > mtx.GetLength(0) || index1 > mtx.GetLength(1)) return no;
    else 
    {
        string yes = Convert.ToString(mtx[index0, index1]);
        return yes;
    } 
}