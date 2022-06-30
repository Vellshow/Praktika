Console.Clear();
int[] array = { 5, 4, 7, 73, 32, 8, 76, 14, 14 };

int n = array.Length;
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
int find = b;

int index = 0;

while(index < n)
{  
    if(array[index] == find)
    {
         Console.WriteLine(index);
         break;        
    }
    index++;
}

// Это не задачи, делал упражнение.