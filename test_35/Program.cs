// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

void Summ(int[] arri)
{
    int Count = 0;
    for (int i = 0; i < arri.Length; i++)
    {
        if (arri[i] > 10 && arri[i] < 100)
        {
            Count = Count + 1;
        }
    }
    Console.Write($"Кол-во => {Count}");
}

void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
}


int[] array1 = CreateArrayRndint(n, minm, maxx);
PrintArray(array1);
Console.WriteLine();
Summ(array1);