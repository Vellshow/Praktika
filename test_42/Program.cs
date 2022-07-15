Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// int TenToTwo(int n)
// {
//     if (n == 1) return 1;
//     if (n == 0) return 0;
//     return n % 2 + 10 * TenToTwo(n / 2);

// }

// Console.WriteLine(TenToTwo(number));

// int d10 = 1;
// int result =0;
// while (number != 0)
// {
//     result = result +number % 2* d10;
//     number =number /2;
//     d10 = d10 *10;
// }
// Console.WriteLine(result);

void ToBin(int n)
{
    if (n == 0) return;
    ToBin(n / 2);
    Console.Write(n % 2);
}
ToBin(number);