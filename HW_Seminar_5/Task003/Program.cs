/* Задача 38: Напишите программу реализующую методы формирования массива, 
заполненного случайными вещественными числами и вычисления разницы между максимальным 
и минимальным элементов массива.
[3,3 7,1 22,5 2,2 78,2] -> 76
*/
using static System.Console;
Clear();

double [] arr = GetArray(5, 1, 10);  //работает с отрицательными значениями
WriteLine("[{0}]", string.Join(" ", arr));
double result = DifValue(arr);
WriteLine($"Разница между максимальным и минимальным элементом массива = {Math.Round(result, 1)}");

double [] GetArray(int size, int min, int max)
{
    double [] array = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()* (max - min) + min, 1);
    }
    return array;
}

double DifValue(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i] > max) 
        {
            max = array[i];
        }
    }
    
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i] < min) 
        {
            min = array[i];
        }
    }
    
    return max-min;
}

