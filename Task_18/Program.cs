// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти 
// (x и y).
Console.WriteLine("Введите первое число x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0)
{
   Console.WriteLine("Точка лежит на оси координат X");
   return;
}
else if (y == 0)
{
   Console.WriteLine("Точка лежит на оси координат Y");
   return;
}

void GetNumberOfQuarter(int x, int y)
{
   if (x > 0 && y > 0)
   {
      Console.WriteLine("Точка лежит в первой четверти");
   }
   if (x < 0 && y > 0)
   {
      Console.WriteLine("Точка лежит в второй четверти");
   }
   if (x < 0 && y < 0)
   {
      Console.WriteLine("Точка лежит в третьей четверти");
   }
   if (x > 0 && y < 0)
   {
      Console.WriteLine("Точка лежит в четвертой четверти");
   }
}
GetNumberOfQuarter(x, y);
