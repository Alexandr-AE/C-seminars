﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 1000)
    System.Console.WriteLine("Число не трехзначное");
else
{
    while (num > 100)
    {
        num = num / 10;
    }
    System.Console.WriteLine(num % 10);
}