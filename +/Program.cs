// // // // // int[] array = new int[8];
// // // // // var rnd = new Random();

// // // // // for (int i = 0; i < array.Length; i++)
// // // // // {
// // // // //     Console.Write($"{array[i] = rnd.Next(0, 200)} ");
// // // // // }

// // // // // Console.WriteLine();
// // // // // //int [] array = {3, 6, 8, 4, 3, 71, 1, 6};

// // // // // void Maxarray(int[] arr)
// // // // // {
// // // // //     int max = arr[0];
// // // // //     int min = arr[0];
// // // // //     for (int i = 0; i < arr.Length; i++)
// // // // //     {
// // // // //         if (max < arr[i])  max = arr[i];
// // // // //         if(arr[i] < min)  min = arr[i];
// // // // //     }
// // // // //     Console.WriteLine($"Максимальное число в Массиве: {max}");
// // // // //     Console.WriteLine($"Минимальное число в Массиве: {min}");
// // // // // }
// // // // // Maxarray(array);

// // // // // Console.WriteLine("Введите цифру от 0 до 9: ");
// // // // // int find = int.Parse(Console.ReadLine());
// // // // // int [] array = new int[10];
// // // // // var rnd = new Random();

// // // // // for (int i = 0; i < array.Length; i++)
// // // // // {
// // // // //     Console.Write($"{array[i] = rnd.Next(0, 10)} ");
// // // // // }
// // // // // Console.WriteLine(array);

// // // // // void Test(int [] arri, int fin)
// // // // // {
// // // // //     int position = -1;
// // // // //     for (int i = 0; i < arri.Length; i++)
// // // // //     {
// // // // //         if(arri[i] == fin) 
// // // // //         {
// // // // //             position = fin;
// // // // //             Console.WriteLine($"Данное число:{position}, находится под индексом:{i}");
// // // // //             break;
// // // // //         }
// // // // //     } 
// // // // // }
// // // // // Test(array, find);

// // // // // Console.WriteLine("Введите имя пользователя: ");
// // // // // string usernume = Console.ReadLine();

// // // // // if (usernume.ToLower() == "велл")
// // // // // {
// // // // //     Console.WriteLine($"{usernume} Big Boss");
// // // // // }
// // // // // else Console.Write($"Привет,{usernume}");
// // // // // =
// // // // Console.Clear();
// // // // // int xa = 40, ya = 1,
// // // // //     xb = 1, yb = 30,
// // // // //     xc = 80, yc = 30;

// // // // // Console.SetCursorPosition(xa, ya);
// // // // // Console.WriteLine("=");
// // // // // Console.SetCursorPosition(xb, yb);
// // // // // Console.WriteLine("=");
// // // // // Console.SetCursorPosition(xc, yc);
// // // // // Console.WriteLine("=");

// // // // // int x = xa, y = xb;

// // // // // int count = 0;
// // // // // while (count < 10000)
// // // // // {
// // // // //     int ran = new Random().Next(0, 3);

// // // // //     if (ran == 0)
// // // // //     {
// // // // //         x = (x + xa) / 2;
// // // // //         y = (y + ya) / 2;
// // // // //     }
// // // // //     if(ran == 1)
// // // // //     {
// // // // //         x = (x + xb) / 2;
// // // // //         y = (y + yb) / 2;
// // // // //     }
// // // // //      if(ran == 2)
// // // // //     {
// // // // //         x = (x + xc) / 2;
// // // // //         y = (y + yc) / 2;
// // // // //     }
// // // // // Console.SetCursorPosition(x, y);
// // // // // Console.WriteLine("+");
// // // // // count++;
// // // // // }

// // // // int Max(int arg1, int arg2, int arg3)
// // // // {
// // // //     int result = arg1;
// // // //     if (arg2 > result) result = arg2;
// // // //     if (arg3 > result) result = arg3;
// // // //     return result;
// // // // }
// // // // int a = 4;
// // // // int b = 54;
// // // // int c = 34;
// // // // int d = 90;
// // // // int e = 640;
// // // // int x = 32;
// // // // int k = 9;
// // // // int m = 6;
// // // // int n = 55;


// // // // int max1 = Max(a, b, c);
// // // // int max2 = Max(d, e, x);
// // // // int max3 = Max(k, m, n);
// // // // int max4 = Max(Max(a, b, c),
// // // //             Max(d, e, x),
// // // //             Max(k, m, n));
// // // // Console.WriteLine( max4);


// // // // 1. Напишите программу, которая на вход принимает два
// // // // числа и проверяет, является ли первое число квадратом
// // // // второго.

// // // // Console.Clear();
// // // // Console.Write("Введите квадрат числа: ");
// // // // int a = int.Parse(Console.ReadLine());
// // // // Console.Write("Введите число которое хотите проверить: ");
// // // // int b = int.Parse(Console.ReadLine());

// // // // double sum = Math.Pow(b, 2);

// // // // if (sum == a)
// // // // {
// // // //     Console.WriteLine($"Число:{a} является квадратом:{b}");
// // // // }
// // // // else Console.WriteLine($"Не является {a} квадратом: {b}");

// // // 3. Напишите программу, которая будет выдавать
// // // название дня недели по заданному номеру.
// // // 3 -> Среда
// // // 5 -> Пятница



// // Console.Clear();
// // Console.WriteLine("Напишите число для сравнения: ");
// // int a = Convert.ToInt32(Console.ReadLine());

// // if(a % 2 == 0) Console.WriteLine($"Число {a} является четным");
// // else Console.WriteLine($"Число {a} является не четным");


// Console.Clear();
// Console.WriteLine("Напишите число для сравнения: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// sum = a%10;

// Console.WriteLine(sum);

// int rnd = new Random().Next(10, 100);
// Console.WriteLine(rnd);

// int a = rnd / 10;
// int b = rnd % 10;

// if (a > b) Console.WriteLine(a);
// if (a == b) Console.WriteLine("равны");
// else Console.WriteLine(b);

// int[] CreateArrayRndint(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// Console.Clear();
// Console.WriteLine("Напишите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] NewArray(int size)
// {
//     int[] array = new int[size];
//     var rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(1, 10);
//     }
//     return array;
// }


// void PrintArray(int[] arri)
// {
//     for (int i = 0; i < arri.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < arri.Length - 1) Console.Write(arri[i] + ",");
//         else Console.Write(arri[i] + "]");
//     }
// }

// void  TreeNumber( int [] arr)
// {
//     int i = 0;
//     int Length = arr.Length;
//     int num = 0;
//     if(Length >3 )
//     {
//         num = arr[2];
//         Console.Write($" Число под 3 тим номером: {num}");
//         return;
//    }
//    else Console.WriteLine("Массив меньше 3");
// }
// int[] array1 = NewArray(n);
// PrintArray(array1);
// Console.WriteLine();
// TreeNumber(array1);

// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// if ((0 < a/100) & (a/100 < 10)) Console.WriteLine(a%10);
// else Console.WriteLine("Введено некоректное число");

// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int b = Convert.ToInt32(Console.ReadLine());


// switch ((a, b))
// {
//     case ( >  ): Console.WriteLine($"{a} больше {b}");
//         break;
//     case ( < ): Console.WriteLine($"{b} больше {a}");
//         break;
//     default: Console.WriteLine("некоректно"); break;

// }
// if (a / 10 < 10)
// {
//     Console.WriteLine("Третьего числа нет");
// }
// else
// {
//     int number = a;
//     while (a / 10 > 100)
//     {
//         a = a/10;
//         number = a;
//     }
//     Console.WriteLine(number%10);
// }


// Console.WriteLine("Введите число:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// double y1 = Convert.ToInt32(Console.ReadLine());Console.WriteLine("Введите число:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// double y2 = Convert.ToInt32(Console.ReadLine());


// double sum = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
// Console.WriteLine(Math.Round(sum, 1
// ));
// double sum = Math.Sqrt(Math.Pow((x2 -x1),2) + Math.Pow((y2 -y1), 2));

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int i =1;
// while(i<=number)
// {
//     Console.WriteLine($"|{i}| = |{i*i , 4}|");
//     i++;
// }

// Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());

// int sum = 0;
// int i = 0;

// while(i<= number)
// {
//     sum = sum + i;
//     i++;
// }
// Console.WriteLine(sum);


// int sum = 0;
// while ( number> 0 )
// {
//     number = number /10;
//     sum++;
// }
// Console.Write(sum);

// Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());

// void Proiz( int num)
// {
//     int sum = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum * i;
//     }
//     Console.WriteLine(sum);
// }
// Proiz(number);

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int e = int.Parse(Console.ReadLine());


// int[] NewArray(int size)
// {
//     int [] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(0, 2);
//     }
//     return array;
// }

// void PrintArray(int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i == 0) Console.Write("[");
//         if(i< arr.Length-1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i] + "]");   
//     }
// }

// int[] array1 =NewArray(e);
// PrintArray(array1);
Console.Clear();
Console.Write("Введите число: ");
int number =Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int a = 0;
// while(number >0)
// {
//     a = number/10;  
//     sum+=a;
// }
// Console.Write(sum);

void PrintSum( int num)
{
    int sum = 0;
    int temp = 0;
    while(num>0)
    {
        temp = num/10;
        num = num;
        sum+=temp;
    }
    Console.WriteLine(sum);
}

PrintSum(number);