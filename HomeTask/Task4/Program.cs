﻿// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите число");
int num= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num3= Convert.ToInt32(Console.ReadLine());

int max=num;
if (num2>=max)
{
   max=num2;
  }
 if (num3>=max)
{
   max=num3;
  }
Console.WriteLine(max);