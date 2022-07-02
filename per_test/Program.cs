Console.Clear();
Console.WriteLine("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Qur(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Не корректный ввод";
}

string result = Qur(x, y);
Console.WriteLine(result);