// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string sum = Console.ReadLine();



void Proverka(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
    Console.WriteLine($"Число {number} является палиндромом");
    }
    else Console.WriteLine($"Число {number} не является палиндромом");
}

if (sum.Length == 5)
{
    Proverka(sum);
}
else Console.WriteLine("Ввели не правильное число!");