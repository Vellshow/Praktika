int[] array = { 1, 3, 4, 6, 5, 33, 11, 67 };

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

void PrintNumber(int[] arr, int num)
{
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] == num)
        {
            Console.WriteLine("Yes");
            return;
        }
        i++;
    }
    Console.Write("NO");
}

PrintNumber(array, number);