/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using static System.Console;
Clear();

int[,,] matrix = GetMatrix2D(2, 2, 2);



PrintMatrix(matrix);
WriteLine();
PrintMatrix(matrix2);
WriteLine();
PrintMatrix(DivMatrix(matrix, matrix2));

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

int[,] DivMatrix(int[,] array, int[,] array2)
{
    
}
