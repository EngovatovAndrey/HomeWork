/* Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

using static System.Console;
Clear();

WriteLine("Введите через пробел, произвольное количество чисел");
string[] UserNumbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Пользователем введено {CountNumbers(UserNumbers)} числа больше нуля");

int CountNumbers(string[] st)
{ 
    int count = 0;
    for (int i = 0; i < st.Length; i++)
    {
        if(Convert.ToInt32(st[i]) > 0)
        {
            count += 1;
        }
    }
    return count;
}