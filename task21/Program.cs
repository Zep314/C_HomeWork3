// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
using System;

Console.Write("Введите координату X1 первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y1 первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z1 первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X2 второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y2 второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z2 второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double P = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)); // вычисление

Console.WriteLine($"Расстояние между двумя точками в 3D равно {P}");
