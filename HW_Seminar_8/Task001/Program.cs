/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using static System.Console;
Clear();

int[,] matrix = GetMatrix2D(4, 5);
PrintMatrix(matrix);
WriteLine();
PrintMatrix(ChangeMatrix(matrix));

int[,] GetMatrix2D(int lines, int column)
{
    int[,] mtx = new int[lines, column];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
            mtx[i, j] = new Random().Next(1,10);
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

int[,] ChangeMatrix(int[,] inArray)
{

    int[,] newArray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
                for (int k = 0; k < inArray.GetLength(1) - j - 1; k++)
                {
                    if (inArray[i, k] < inArray[i, k + 1])
                    {

                        int t = inArray[i, k];

                        inArray[i, k] = inArray[i, k + 1];

                        inArray[i, k + 1] = t;

                    }
                }

            }

        }
        return inArray;
    }



