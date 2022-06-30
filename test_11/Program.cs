Console.Clear();
int random = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число от 100 до 1000 => {random}");

int a = random / 100;
int b = (random / 10) % 10;
int c = random % 10;

Console.WriteLine(a);
Console.WriteLine(c);
