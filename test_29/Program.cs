// Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int [] array = new int[8] {1, 2, 5, 7, 19, 6, 1, 33};

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintArray(array);