// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] RandomArray()
{
    Random rnd = new Random();
    int[,] array = new int[4, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
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

int[] MatrixArray(int[,] arr)
{
    // int[,] array2 = new int[arr.GetLength(0), arr.GetLength(1)];
    int[] Array3 = new int[arr.GetLength(0)];

    int k = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Array3[k] = sum;
        k++;
    }
    return Array3;
}

void Print1(int[] arri)
{
    for (int i = 0; i < arri.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
        }
        if (i < arri.Length - 1)
        {
            Console.Write(arri[i] + ",");
        }
        else Console.Write(arri[i] + "]");
    }
}

void MinString(int[] Arrr)
{
    int i = 0;
    int min = Arrr[i];
    int k =0;
    while (i < Arrr.Length)
    {
        if (min > Arrr[i])
        {
            min = Arrr[i];
            k = i;
        }
        else i++;
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов ==> {k} строка");
}
int[,] Array1 = RandomArray();
PrintMatrix(Array1);
Console.WriteLine();
int[] Arrs = MatrixArray(Array1);
Print1(Arrs);
Console.WriteLine();
MinString(Arrs);