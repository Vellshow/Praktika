Console.Clear();
Console.Write("Введите значение первой Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение первой Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение второго Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение второго Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());



double sum = Math.Sqrt(Math.Pow((x2 -x1),2) + Math.Pow((y2 -y1), 2));
Console.WriteLine(Math.Round(sum, 3));