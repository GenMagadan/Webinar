﻿// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

void TableOfSquares(int N)
{
   for (int i = 1; i <= N; i++)
   {
      Console.Write($"{i * i}, ");
   }
}
TableOfSquares(N);