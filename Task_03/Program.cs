// Напишите программу, которая будет выдавать название дня недели 
// по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine());

if (n == 1)
{
   Console.WriteLine($"{n} -> Понедельник");
}
else if (n == 2)
{
   Console.WriteLine($"{n} -> Вторник");
}
else if (n == 3)
{
   Console.WriteLine($"{n} -> Среда");
}
else if (n == 4)
{
   Console.WriteLine($"{n} -> Четверг");
}
else if (n == 5)
{
   Console.WriteLine($"{n} -> Пятница");
}
else if (n == 6)
{
   Console.WriteLine($"{n} -> Суббота");
}
else if (n == 7)
{
   Console.WriteLine($"{n} -> Воскресенье");
}
else
{
   Console.WriteLine($"{n} -> Некорректно введен номер недели");
}
