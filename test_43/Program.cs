// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите число b1: ");
int t1 = int.Parse(Console.ReadLine());
Console.Write("Введите число k1: ");
int r1 = int.Parse(Console.ReadLine());
Console.Write("Введите число b2: ");
int t2 = int.Parse(Console.ReadLine());
Console.Write("Введите число k2: ");
int r2 = int.Parse(Console.ReadLine());

void PritXY(int b1, int k1, int b2, int k2)
{
    double y = 0;
    double x = 0;
    {
        if ((b1 == b2) && (k1 == k2))
        {
            Console.Write("Прямые совпадают");
            return;
        }
        else if (b1 == b2)
        {
            Console.Write("Прямые параллельные");
            return;
        }
        else x = (b2 - b1) / (k1 - k2);
        y =  Math.Round(k1 * x + b1, 1);
;
    }
    Console.WriteLine($"х = {x} y = {y}");
}
PritXY(t1, r1, t2, r2);

// Подскажите в чем ошибка он (-0.5) не выдает и меньшн 0 тоже