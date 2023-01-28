/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using static System.Console;
Clear();

int[,] matrix = GetMatrix2D(2, 2);
int[,] matrix2 = GetMatrix2D(2, 2);

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
            Write($"{matrix[i, j],3} ");
        }
        WriteLine();
    }
}

int[,] DivMatrix(int[,] array, int[,] array2)
{
    var newMatrix = new int[array.GetLength(0), array2.GetLength(1)];
    if (array.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                newMatrix[i, j] = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    newMatrix[i, j] += array[i, k] * array2[k, j];
                }
            }
        }
    }
    return newMatrix;
}


