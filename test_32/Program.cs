int [] array = {-8, 4 ,-6, 2};

int [] app (int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i]* -1;
    }
    return arr;
}

void Print (int [] arri)
{
    for (int i = 0; i < arri.Length; i++)
    {
        if(i == 0) Console.Write('[');
        if(i < arri.Length-1) Console.Write(arri[i] + ",");
        else Console.Write(arri[i] + "]");
    }
}

int [] array2 = app(array);
Print(array2);