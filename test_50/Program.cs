// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите столб: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите строку: ");
int b = int.Parse(Console.ReadLine());

Console.Clear();
int[,] CreateMatrixRndInt()
{

    int[,] arr = new int[3, 4];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10); ;
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4} | ");
            else Console.Write($"{arr[i, j],4} | ");
        }
        Console.WriteLine();
    }
}

void ElementSeartch(int[,] arra1, int column, int line)
{
    for (int i = 0; i < arra1.GetLength(0); i++)
    {
        for (int j = 0; j < arra1.GetLength(1); j++)
        {
            if(column == i && line ==j)
            {
               Console.Write($" Число под указанными даными ={column},{line} = {arra1[i, j]}");
               return;
            }
        }
    }
    Console.Write($" Число под указанными даными ={column},{line} = Нету");
}

int[,] array1 = CreateMatrixRndInt();
PrintMatrix(array1);
Console.WriteLine();
ElementSeartch(array1, a, b);
