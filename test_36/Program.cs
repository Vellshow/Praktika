// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите длинну массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int b = int.Parse(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void Print( int [] arri)
{
    for (int i = 0; i < arri.Length; i++)
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

void PrintSum ( int [] arr)
{
    int sum = 0;
    int i = 1;
    while(i <= arr.Length)
    {
        sum = sum + arr[i];
        i = i+2;
        
    }
    Console.Write(sum);
}
int[] array1 = RandomArray(n, a, b);
Print(array1);
Console.WriteLine();
PrintSum(array1);