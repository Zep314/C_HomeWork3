// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
using System;

Console.Write("Введите число N, больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N<1)
{
    Console.WriteLine("Введены неверные данные.");
}
else
{
    for(int i=1; i<=N; i++)
    {
        Console.WriteLine($"Куб числа {i} равен {Math.Pow(i,3)}");
    }
}