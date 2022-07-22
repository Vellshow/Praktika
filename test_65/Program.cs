// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Clear();
Console.Write($"Введите число М: ");
int M = int.Parse(Console.ReadLine());
Console.Write($"Введите число N: ");
int N = int.Parse(Console.ReadLine());


int SumNamber(int number1, int number2)
{
    if (number1 == number2) return number2;
    return SumNamber(number1 + 1, number2) + number1;
}

if (M < N)
{
    int v = SumNamber(M, N);
    Console.Write(v);
}
if (M > N)
{
    int temp = 0;
    temp = M;
    M = N;
    N = temp;
    int v = SumNamber(M, N);
    Console.Write(v);
}