// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите длинну массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальную длину числа: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальную длинну числа : ");
int max = int.Parse(Console.ReadLine());

int [] NewArray(int size, int minn, int maxx)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(minn, maxx+1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] array2 = NewArray(n, min, max);
PrintArray(array2);
PrintChet(array2);

void PrintChet(int [] arri)
{ 
    int Length = arri.Length-1;
    int count =0;
    int i = 0; 
    while(i <= Length)
    {
        count++;
        i= i+2;
    }
    Console.Write($"Кол-во четных элементов: {count}");
}