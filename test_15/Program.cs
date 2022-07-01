Console.Clear();
Console.Write("Введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 6 || num == 7) Console.WriteLine ("Да выходной");
else if(num < 6) Console.WriteLine("Нет не выходной");
else Console.WriteLine($"Данного дня недели не существует {num}");