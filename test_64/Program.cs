// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// ___________________________________
// // 66 задача находится в test 65!
// ____________________________________
Console.Clear();
Console.Write("Введите число для проверки: ");
int m = int.Parse(Console.ReadLine());

void Decomposition(int number)
{
    if(number>0)
    {
    if (number == 0) return;
    Console.Write($"{number} ");
    Decomposition(number - 1);
    }

    if(number<0)
    {
    if (number == 0) return;
    Console.Write($"{number} ");
    Decomposition(number + 1);
    }
}

Decomposition(m);
