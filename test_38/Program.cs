// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.Clear();
Console.WriteLine("Введите длинну массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
double a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
double b = int.Parse(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    double[] array = new double[size];

    for (double i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void Print( double [] arri)
{
    for (double i = 0; i < arri.Length; i++)
    {
        if(i == 0)
        {
            Console.Write("[");
        }
        if(i< arri.Length-1)
        {
            Console.Write(arri[i] + ",");
        }
        else Console.Write(arri[i] + "]");
    }
}

void PrintMaxMin( double [] arr)
{
    int i = 0;
    double max = arr[0];
    double min = arr[0];
    double sum = 0;

    while(max < arr.Length)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
        if(arr[i]< min)
        {
            min = arr[i];
        }
    }
    Console.Write($"Разница между минимальным значение и максимальным{max-min}");
}

double [] array1 = RandomArray(n, a, b);
Print(array1);
PrintMaxMin(array1);