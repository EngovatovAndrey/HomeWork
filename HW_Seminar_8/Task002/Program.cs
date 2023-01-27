/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using static System.Console;
Clear();

int[,] matrix = GetMatrix2D(4, 4);
PrintMatrix(matrix);
WriteLine();
FindMinSumLine(matrix);

int[,] GetMatrix2D(int lines, int column)
{
    int[,] mtx = new int[lines, column];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
            mtx[i, j] = new Random().Next(1, 10);
        }
    }
    return mtx;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j],2} ");
        }
        WriteLine();
    }
}

void FindMinSumLine(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
            index = 1;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i+1;
        }
    }
    WriteLine($"Номер строки с наименьшей суммой элементов: {index} строка.");
}

