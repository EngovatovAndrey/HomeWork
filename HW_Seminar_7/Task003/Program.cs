/* Напишите программу реализующую методы, формирования двумерного массива 
и массива средних арифметических значений каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using static System.Console;
Clear();

int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
WriteLine(" {0}", string.Join("; ", MatrixLineMidleSum(matrix)));

int[,] GetMatrix(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            //matrix[i, j] = new Random().Next(1, 10);
            matrix[i, j] = new Random().Next(1, 10);

        }
    }
    return matrix;
}
void PrintMatrix(int[,] mtx)
{
    WriteLine("Заданный двумерный массив");
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            Write($"{mtx[i, j], 3} ");
        }
        WriteLine();
        WriteLine();
    }
}
double[] MatrixLineMidleSum(int[,] mtx)
{

    double[] resultTotal = new double[mtx.GetLength(1)];

    for (int j = 0; j < mtx.GetLength(1); j++)
    {
        double summ = 0.0;
        for (int i = 0; i < mtx.GetLength(0); i++)
        {
            summ += mtx[i, j];
            double result = summ / mtx.GetLength(0);
            resultTotal[j] = Math.Round(result, 1);
        }
    }
    return resultTotal;
}