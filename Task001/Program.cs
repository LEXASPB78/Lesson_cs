﻿// Напишите программу, которая на вход принимает число и выдает его квадрат
// (число умноженное на само себя).

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
System.Console.WriteLine("Квадрат числа равен ");
Console.WriteLine(result);
