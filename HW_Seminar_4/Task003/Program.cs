/* Напишите программу, реализующую метод, который формирует массив случайных целых чисел 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]
*/

using static System.Console;
Clear();

int[] arr = GetArray(8);
WriteLine("[{0}]", string.Join(", ", arr)); // вывод массива целиком без цикла

int[] GetArray(int size)
{
    int[] arr = new int[size]; // создаем пустой список с заданным размером
    
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100); // наполняем массив случайными числами в диаппазоне
    }
    return arr;
}
