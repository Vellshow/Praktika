// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int max = int.Parse(Console.ReadLine());

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

int[,] Array(int[,] Arr)
{
    int[,] arrs = new int[Arr.GetLength(0), Arr.GetLength(1)];
    arrs = Arr;
    int index = Arr[Arr.GetLength(0) - 1, Arr.GetLength(1) - 1];
    int index2 = Arr[0, 0];


    arrs[0, 0] = index;
    arrs[arrs.GetLength(0) - 1, arrs.GetLength(1) - 1] = index2;
    return arrs;
}

 
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(number, num, min, max);
PrintMatrix(arrayResult);
int[,] arrss = Array(arrayResult);
Console.WriteLine();
PrintMatrix(arrss);