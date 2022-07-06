int[] array = { 1, 2, 5, 4, 7, 69, 55, 4 };

void Printarray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Printarray(array);
Console.WriteLine();

void SelectionSort(int[] arri)
{
    for (int i = 0; i < arri.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < arri.Length; j++)
        {
            {
            if (arri[j] < arri[min]) min = j;
            }
        }
        int temp = arri[i];
        arri[i] = arri[min];
        arri[min] = temp;
    }
}

SelectionSort(array);
Printarray(array);
