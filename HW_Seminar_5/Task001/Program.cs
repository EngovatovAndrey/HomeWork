// Задача 34: Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, и подсчета 
// количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

int[] arr = GetArray(5, 100, 1000);
WriteLine("[{0}]", string.Join(", ", arr));
int count1 = CountArray(arr);
WriteLine($"Количество четных элементов в массиве = {count1}");

int[] GetArray(int size, int start,int finish)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i =0; i < size; i++)
    {
        array[i] = rnd.Next(start, finish);
    } 
    return array;
}

int CountArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2== 0) 
        {
            count +=1;
        }
    }
    return count;
}