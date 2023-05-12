﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 999)
{
   Console.WriteLine($"{number} -> {number % 10}");
}
else
{
   Console.WriteLine($"{number} -> Введено неправильное число");
}
