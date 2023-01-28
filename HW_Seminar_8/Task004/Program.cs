/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using static System.Console;
Clear();

int[,,] matrix = GetMatrix3D(2, 2, 2);
PrintMatrix3D(matrix);

int[,,] GetMatrix3D(int x, int y, int z)
{
    int[] array = new int[90];
    int e = 0;
    for (int i = 10; i < 100; i++)
    {
        array[e] = i;
        e++;
    }
    int[] randomBase = Shuffle(array);

    int[,,] mtx = new int[x, y, z];
    int index = 0;

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            for (int k = 0; k < mtx.GetLength(2); k++)
            {
                //mtx[i, j, k] = new Random().Next(10, 99); 
                mtx[i, j, k] = randomBase[index];
                index++;
            }
        }
    }
    return mtx;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Write("{0}", string.Join(", ", matrix[i, j, k]));
                Write($"({i}, {j}, {k}) ");
            }
            WriteLine();
        }
    }
}

int[] Shuffle(int[] array)
{
    var random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        var key = array[i];
        var rnd = random.Next(i, array.Length);
        array[i] = array[rnd];
        array[rnd] = key;
    }
    return array;
}


