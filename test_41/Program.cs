// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = int.Parse(Console.ReadLine());

int [] NewArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i==0) 
        {
            Console.Write("[");
        }
        if(i < arr.Length-1) 
        {
            Console.Write(arr[i] + ",");
        }
        else 
        {
            Console.Write(arr[i] +"]");
        }
    }
}


void Chetpoll(int [] arris)
{
    int sum =0;
    for (int i = 0; i < arris.Length; i++)
    {
        if(arris[i]> 0)
        {
            sum++;
        }
    }
    Console.Write($"Сумма положительных чисел: {sum}");
}
int [] array1 = NewArray(n);
PrintArray(array1);
Console.WriteLine();
Chetpoll(array1);