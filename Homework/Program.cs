﻿// Задача 1: Напишите программу, которая 
// принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// int number = 966;
// if(number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"Число {number} кратно одновременно числу 7 и числу 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно");
// }


// Задача 2: Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// int x = 5;
// int y = -3;

// if(x > 0 && y > 0)
// {
//     Console.WriteLine("Введены координаты первой четверти");
// }
// if(x < 0 && y > 0)
// {
//     Console.WriteLine("Введены координаты второй четверти");
// }
// if(x < 0 && y < 0)
// {
//     Console.WriteLine("Введены координаты третьей четверти");
// }
// if(x > 0 && y < 0)
// {
//     Console.WriteLine("Введены координаты четвёртой четверти");
// }

// Задача 3: Напишите программу, которая 
// принимает на вход целое число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

// int number = 983;
// if(number > 9 && number < 100)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;
//     if(secondDigit > firstDigit)
//     {
//         Console.WriteLine($"В числе {number} бОльшая вторая цифра: {secondDigit}");
//     }
//     if(firstDigit > secondDigit)
//     {
//         Console.WriteLine($"В числе {number} бОльшая первая цифра: {firstDigit}");
//     }
// }
// else{
//     Console.WriteLine("Число не двухзначное");
// }

// Задача 4: Напишите программу, 
// которая на вход принимает натуральное 
// число N, а на выходе показывает его 
// цифры через запятую.

int number = 4345;

if (number > 1000)
{
    int firstDigit = number / 1000;
    int secondDigit = number / 100 % 10;
    int thirdDigit = number / 10 % 10;
    int fourthDigit = number % 10;
    Console.WriteLine($"{firstDigit},{secondDigit},{thirdDigit},{fourthDigit}");
}
if (number > 100 && number > 10 && number < 1000)
{
    int firstDigit = number / 100 % 10;
    int secondDigit = number / 10 % 10;
    int thirdDigit = number % 10;
    Console.WriteLine($"{firstDigit},{secondDigit},{thirdDigit}");
}
if (number > 10 && number < 100)
{
    int firstDigit = number / 10 % 10;
    int secondDigit = number % 10;
    Console.WriteLine($"{firstDigit},{secondDigit}");
}



