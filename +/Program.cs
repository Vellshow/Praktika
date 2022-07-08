// int[] array = new int[8];
// var rnd = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i] = rnd.Next(0, 200)} ");
// }

// Console.WriteLine();
// //int [] array = {3, 6, 8, 4, 3, 71, 1, 6};

// void Maxarray(int[] arr)
// {
//     int max = arr[0];
//     int min = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (max < arr[i])  max = arr[i];
//         if(arr[i] < min)  min = arr[i];
//     }
//     Console.WriteLine($"Максимальное число в Массиве: {max}");
//     Console.WriteLine($"Минимальное число в Массиве: {min}");
// }
// Maxarray(array);

// Console.WriteLine("Введите цифру от 0 до 9: ");
// int find = int.Parse(Console.ReadLine());
// int [] array = new int[10];
// var rnd = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i] = rnd.Next(0, 10)} ");
// }
// Console.WriteLine(array);

// void Test(int [] arri, int fin)
// {
//     int position = -1;
//     for (int i = 0; i < arri.Length; i++)
//     {
//         if(arri[i] == fin) 
//         {
//             position = fin;
//             Console.WriteLine($"Данное число:{position}, находится под индексом:{i}");
//             break;
//         }
//     } 
// }
// Test(array, find);

// Console.WriteLine("Введите имя пользователя: ");
// string usernume = Console.ReadLine();

// if (usernume.ToLower() == "велл")
// {
//     Console.WriteLine($"{usernume} Big Boss");
// }
// else Console.Write($"Привет,{usernume}");
// =
// Console.Clear();
// int xa = 40, ya = 1,
//     xb = 1, yb = 30,
//     xc = 80, yc = 30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("=");
// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("=");
// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("=");

// int x = xa, y = ya;

// int count = 0;
// while (count < 10)
// {
//     int ran = new Random().Next(0, 3);

//     if (ran == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if(ran == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//      if(ran == 1)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
// Console.SetCursorPosition(x, y);
// Console.WriteLine("=");
// }