int a = 15;
int f1= 0;
int f2 = 1;
int num = 0;
for (int i = 1; i <= a; i++)
{
    num = f1 +f2;
    f1= f2;
    f2 = num;
    Console.WriteLine($"F({i}) = {num}");
}