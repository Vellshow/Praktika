// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write("Введите первую точку х1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите первую точку y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите первую точку c1: ");
int c1 = int.Parse(Console.ReadLine());
Console.Write("Введите первую точку x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите первую точку y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите первую точку c2: ");
int c2 = int.Parse(Console.ReadLine());

double sum = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((c2 -c1) ,2));

Console.WriteLine(Math.Round(sum, 2));