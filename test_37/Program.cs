﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
Console.WriteLine("Введите длинну массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int minm = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int maxx = int.Parse(Console.ReadLine());

int[] CreateArrayRndint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void Print(int[] arri)
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


void Umno(int[] array2, int nn)
{
    int j = array2.Length - 1;
    for (int i = 0; i < (array2.Length+1)/2; i++)
    {
        Console.Write(array2[i] * array2[j] + " ");
        j--;
    }
    if (nn % 2 > 0)
    Console.Write(array2[array2.Length / 2]);
}
int[] array1 = CreateArrayRndint(n, minm, maxx);
Print(array1);
Console.WriteLine();
Umno(array1, n);