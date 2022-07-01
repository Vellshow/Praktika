Console.Clear();
var rnd = new Random();
int a = rnd.Next(10, 1000);
int num1 = 0;

Console.WriteLine(a);

if(a<100) Console.WriteLine("Нету третий цифры");
else if(a>10)
{
    num1 = (a%10);
    Console.WriteLine($"Третья цифра:{num1}");
}
