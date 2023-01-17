/*
Задача 36: Напишите программу реализующую методы формирования массива, 
заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using static System.Console;
Clear();

int[] arr = GetArray(4, -10, 10);
WriteLine("[{0}]", string.Join(", ", arr));

int result = count(arr);
WriteLine(result);

int[] GetArray(int size, int start, int finish)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(start, finish);
    }
    return array;
}

int count(int[] array)
{
    int count = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        count += array[i]; 
    }
    return count;
}