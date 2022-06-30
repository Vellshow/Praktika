Console.Clear();
int random =new Random().Next(10, 100);
Console.WriteLine($"Рандомное число {random}");

int first = random / 10;
int second = random % 10;

if(first > second) Console.WriteLine($"Первое число больше: {first}");
else if(first < second) Console.WriteLine($"Второе число больше: {second}");
else Console.WriteLine($"Числа равны: {random}");