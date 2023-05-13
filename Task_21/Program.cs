// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты первой точки: ");
double xa = double.Parse(Console.ReadLine());
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты пвторой точки: ");
double xb = double.Parse(Console.ReadLine());
double yb = double.Parse(Console.ReadLine());

double length = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
Console.WriteLine($"A({xa},{xb}); B({ya},{yb}) -> {Math.Round(length, 2)}");