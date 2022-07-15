// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Clear();
Console.WriteLine("Введите длинну массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int b = int.Parse(Console.ReadLine());

double[] RandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();


    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}


void Print(double[] arri)
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

double PrintMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];

        else if (min > arr[i]) min = arr[i];
    }
    double [] arrw = {min, max};
    return arrw;
}

    double[] array1 = RandomArray(n, a, b);
    Print(array1);
    Console.WriteLine();
    double [] arr2 =PrintMaxMin(array1);