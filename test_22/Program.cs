Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 1;
while (a <= n)
{
    double b = Math.Pow(a, 2);
    Console.WriteLine($"{a}  |  {b}");
    a +=1;
}




// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int a = 1;
// while (a <= n)
// {
//     Console.WriteLine($"{a}  |  {a*a}");
//     a++;
// }