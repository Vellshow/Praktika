Console.Clear();
Console.WriteLine("Введите число: ");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b =int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int c =int.Parse(Console.ReadLine());

if(a<(b+c) && b<(a+c) && c<(a+b)) Console.WriteLine("Существует");
else Console.WriteLine("Несуществует");