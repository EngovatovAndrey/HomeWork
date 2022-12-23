// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

WriteLine("Введите координаты X1 , Y1, Z1");
int x1 = Convert.ToInt32(ReadLine());
int y1 = Convert.ToInt32(ReadLine());
int z1 = Convert.ToInt32(ReadLine());

WriteLine("Введите координаты X2 , Y2, Z2");
int x2 = Convert.ToInt32(ReadLine());
int y2 = Convert.ToInt32(ReadLine());
int z2 = Convert.ToInt32(ReadLine());

double length = Convert.ToDouble(Math.Sqrt(Math.Pow((x2-x1), 2) 
        + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)));

WriteLine($"Расстояние равно {Math.Round(length, 2)}");
