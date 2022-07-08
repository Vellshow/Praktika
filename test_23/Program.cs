// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число кторое хотите возвести к куб: ");
int num = int.Parse(Console.ReadLine());

int i= 1;

while(i <=num)
{
    double run = Math.Pow(i, 3);
    Console.WriteLine(run);
    i++;
}