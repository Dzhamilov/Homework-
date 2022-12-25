/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите значение Х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение X2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine(Math.Round(result, 2) );