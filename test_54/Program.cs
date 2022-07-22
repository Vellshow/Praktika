// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

Console.Clear();
Console.Write("Задайте длину столбца: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Задайте ширину столбца: ");
int line = int.Parse(Console.ReadLine());


int[,] array1 = NewArray(size, line);

int[,] NewArray(int siz, int n)
{
    Random rnd = new Random();
    int[,] array = new int[siz, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
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

int[,] PorArray(int[,] arrray1)
{
    for (int i = 0; i < arrray1.GetLength(0); i++)
    {

        for (int j = 0; j < arrray1.GetLength(1); j++)
        {
            for (int k = 0; k < arrray1.GetLength(1) - 1; k++)
            {
                if (arrray1[i, k] > arrray1[i, k + 1])
                {
                    int temp = arrray1[i, k + 1];
                    arrray1[i, k + 1] = arrray1[i, k];
                    arrray1[i, k] = temp;
                }

            }
        }

    }
    return arrray1;
}

PrintMatrix(array1);
Console.WriteLine();
int[,] arra = PorArray(array1);
PrintMatrix(array1);