// Console.Clear();
// Console.Write("Введите порядковый номер дня недели: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (a == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (a == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (a == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (a == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (a == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (a == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Нету такого дня недели"); break;
}