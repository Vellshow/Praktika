Console.Clear();
Console.WriteLine("Первая четверть => 1 ");
Console.WriteLine("Вторая четверть => 2 ");
Console.WriteLine("Третья четверть => 3 ");
Console.WriteLine("Четвертая четверть => 4 ");
Console.Write("Введите число соответствующий четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1: Console.WriteLine("x > 0, y > 0"); break;
    case 2: Console.WriteLine("x < 0, y > 0"); break;
    case 3: Console.WriteLine("x < 0, y < 0"); break;
    case 4: Console.WriteLine("x > 0, y < 0"); break;
    default: Console.WriteLine("Данной четверти нет"); break;
}