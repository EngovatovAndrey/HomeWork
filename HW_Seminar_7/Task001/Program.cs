/* Напишите программу реализующую метод, который возвращает массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

using static System.Console;
Clear();

double[,] matrix = GetMatrixDigits(3, 4);
PrintMatrix(matrix);

double[,] GetMatrixDigits(int m, int n)
{
    double[,] matrix1 = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix1[i,j] = new Random().Next(-10, 10)*0.2;
        }
    }
    return matrix1;
}

void PrintMatrix(double[,] mtx)
{
    for(int i = 0; i < mtx.GetLength(0); i++)
    {
        for(int j = 0; j < mtx.GetLength(1); j++)
        {
            Write($"{Math.Round(mtx[i, j], 1)} ");
        }
        WriteLine();
        WriteLine();
    }
}