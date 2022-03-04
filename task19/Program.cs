// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

using System;

Console.Write("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 10000) && (number <= 99999))  // проверяем введенное число на пятизначность
{
    string str1 = Convert.ToString(number);  // переводим в строку
    Boolean flag = false;  // флаг для сигнализации одинаковых или разных цифр в числе
    for(int i=0;i<2;i++)
    {
        if (str1[i]!=str1[4-i]) // сравнение цифр в числе
        {
            flag = true;  // устанавливаем флаг о том, что цифры в числе разные
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
