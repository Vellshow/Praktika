Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;

if(n % num1 == 0 && n % num2 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Некратное");
}