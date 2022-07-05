// void Metod2(string mse)
// {
//     Console.WriteLine(mse);
// }

// Metod2("Валентин");

// void ms(string sm, int count)
// {
//     int i = 0;
//     while(i< count)
//     {
//         Console.WriteLine(sm);
//         i++;
//     }
// }
// ms(sm: "Валентин", 5);

Console.WriteLine("");
int num = Convert.ToInt32(Console.ReadLine());

int Ber(int number)
{
    int i = 0;
    for ( ; number > 0; i++)
    {
        number = number / 10;
        
    }
    return i;
}
int re = Ber(num);
Console.WriteLine(re);