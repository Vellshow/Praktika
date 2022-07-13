// Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int [] array = new int[8] {1, 2, 5, 7, 19, 6, 1, 33};


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


Print(array);