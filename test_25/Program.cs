// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите в какую степень возвести: ");
int b = int.Parse(Console.ReadLine());

void Print (int num, int c)
{
    int sum = 1;
    for (int i = 1; i <= c; i++)
    {
        sum = sum* num;
    }
    Console.WriteLine($"число {num} в натуральной степени {c} = {sum}");
}

Print(a, b);