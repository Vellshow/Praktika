// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Задайте длину столбца: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Задайте ширину столбца: ");
int line = int.Parse(Console.ReadLine());

Console.Clear();
int[,] CreateMatrixRndInt(int size, int line)
{

    int[,] arr = new int[size, line];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10); ;
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4} | ");
            else Console.Write($"{arr[i, j],4} | ");
        }
        Console.WriteLine();
    }
}

int[] SumMatrix(int[,] array1)
{
    int[] Array2 = new int[array1.GetLength(0)];
    int f = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            sum = sum + array1[i, j];
        }
        Array2[f] = sum;
        f++;
    }
    return Array2;
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
            Console.Write(arri[i] + ";");
        }
        else Console.Write(arri[i] + "]");
    }
}

double [] NumberDivision(double [] Array3, int lin)
{
    for (int i = 0; i < Array3.Length; i++)
    {
        Array3[i] = Math.Round((Array3[i] /lin),1);
    }
    return Array3;
}

double[] NewDouble ( int[] arrs)
{
    double [] Array5 = new double[arrs.Length];
    for (int i = 0; i < arrs.Length; i++)
    {
       Array5[i] = Convert.ToDouble(arrs[i]);
    }
    return Array5;
}
void Print1(int[] arri)
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

int[,] array1 = CreateMatrixRndInt(size, line);
PrintMatrix(array1);
Console.WriteLine();
int[] NewArray2 = SumMatrix(array1);
Print1(NewArray2);
Console.WriteLine();
double [] New1 = NewDouble(NewArray2);
Console.WriteLine();
double [] New = NumberDivision(New1, line);
Print(New);


