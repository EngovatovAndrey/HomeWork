/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

using static System.Console;
Clear();

WriteLine("Введите через пробел значение b1 и k1");
string[] parametr = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] LineA = {Convert.ToDouble(parametr[0]), Convert.ToDouble(parametr[1])};
WriteLine("Введите через пробел значение b2 и k2");
string[] parametr2 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] LineB = {Convert.ToDouble(parametr2[0]), Convert.ToDouble(parametr2[1])};
double pointX = (LineB[0] - LineA[0])/(LineA[1]- LineB[1]);
double pointY = LineA[1]*pointX + LineA[0];

WriteLine($"({pointX}; {pointY})");
