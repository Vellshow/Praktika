// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

while (b <= a)
{
    Console.WriteLine(b);
    b =( b + 2);
}
