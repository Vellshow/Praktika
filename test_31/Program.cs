Console.Clear();
int [] array = new int [12];
var rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i] = rnd.Next(-10, 20)} ");
}
Console.WriteLine();

int poll = 0;
int otr = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]> 0)
    {
        poll = poll +array[i];
    }
    if(array[i]< 0)
    {
        otr = otr + array[i];
    }
}
Console.WriteLine(poll);
Console.Write(otr);