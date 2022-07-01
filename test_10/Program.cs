Console.Clear();
var rnd = new Random();
int num = rnd.Next(100, 1000);
Console.WriteLine(num);
int a1 = 0;

if (num < 1000)
{
    a1 = (num / 10) % 10;
    Console.Write(a1);
}