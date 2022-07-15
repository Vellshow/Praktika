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

void Print(int[] arri)
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

int [] Array2(int[] arri)
{
    int temp = 0;
    int j = arri.Length - 1;
    for (int i = 0; i < j; i++)
    {
        temp = arri[i];
        arri[i] = arri[j];
        arri[j] = temp;
        j--;
    }
    return arri;
}

int [] arrayq= CreateArrayRndint(n, minm, maxx);
Print(arrayq);
Console.WriteLine();
int [] arrs = Array2(arrayq);
Print(arrs); 