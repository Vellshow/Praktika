// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine ($"Макс число {a}");
    Console.Write ($"Мин число {b}");
}
else if(a < b)
{
    Console.WriteLine ($"Макс число {b}");
    Console.WriteLine ($"Мин число {a}");
}
