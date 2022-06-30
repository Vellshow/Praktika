Console.Clear();
Console.WriteLine("Ведите число которое хотите проверить:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число:");
int num2 = Convert.ToInt32(Console.ReadLine());

string result = num1%num2 == 0? $"{num1} Кратное {num2}" : $"{num1} Остаток {num2} = {num1%num2}";
Console.WriteLine(result);