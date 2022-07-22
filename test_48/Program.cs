// <!-- Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
//  -->
Console.Clear();
Console.WriteLine("Укажите длину массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите длину массива: ");
int cn = int.Parse(Console.ReadLine());

int[,] NewArray(int size, int length)
{
    int[,] array = new int[size, length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

// int[,] CreateMatrixRndInt(int m, int n)
// {
//     int[,] arr = new int[m, n];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return arr;
// }


// void PrintArray(int[,] arri)
// {
//     for (int i = 0; i < arri.GetLength(0); i++)
//     {
//         for (int j = 0; j < arri.GetLength(1); i++)
//         {
//             if (j == 0) Console.Write("|");
//             if (j < arri.GetLength(1) - 1) Console.Write($"{arri[i, j],3} + |");
//             else Console.Write($"{arri[i, j],3} + ]");
//         }
//         Console.WriteLine();
//     }
// }

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

int[,] array1 = NewArray(n, cn);
PrintMatrix(array1);