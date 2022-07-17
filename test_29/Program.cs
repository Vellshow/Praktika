// Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine());


int [] NewArray( int size)
{
    Random rnd = new Random();
    int [] Array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = rnd.Next(0, 100);
    }
    return Array;
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

int [] Array1 = NewArray(n);
Print(Array1);