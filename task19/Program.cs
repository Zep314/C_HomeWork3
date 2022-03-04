// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

using System;

Console.Write("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 10000) && (number <= 99999))
{
    string str1 = Convert.ToString(number);
    Boolean flag = false;
    for(int i=0;i<2;i++)
    {
        if (str1[i]!=str1[4-i])
        {
            flag = true;
            break;
        }
    }
    if (flag)
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено неверное число.");
}
