﻿// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).

Console.WriteLine("Введите число");
int num= Convert.ToInt32(Console.ReadLine());

if ((num%2)!=0)
{
    Console.WriteLine("Число не четное");
}
else
Console.WriteLine("Число четное");