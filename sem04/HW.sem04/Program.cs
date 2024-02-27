// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. Программа завершается 
// при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.


//     while(true)
// {
//     Console.WriteLine("Пожалуйста, введите целое число: ");
//     string text = Console.ReadLine();
//     if(text == "q")
//     {
//         Console.WriteLine("Программа закончена");
//         break;
//     }
//     int number; // 0, если ошибка ИЛИ само число
//     if(int.TryParse(text, out number)) // true, строка состоит только из чисел
//     {
//         int sum = 0;
//         while(number > 0)
//         {
//         sum += number % 10;
//         number /= 10;
//         }
//         if (sum % 2 == 0) 
//         {
//         Console.WriteLine("Программа закончена");
//         break;
//         }       
//     }
// }



// Задача 2: Задайте массив заполненный случайными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for( int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int countEvenNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateArray(N); // Создали массив на N элементов
// Console.WriteLine($"Массив: [ {string.Join("; ", res)}]");
// Console.WriteLine($"Результат: {countEvenNumbers(res)}");


// Задача 3: Напишите программу, которая 
// перевернёт одномерный массив (первый элемент 
// станет последним, второй – предпоследним и т.д.)




using System;

class Program
{
    static void Main(string[] args)
    {
        // Исходный массив
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        Console.WriteLine("\nПеревернутый массив:");
        PrintArray(array);
    }

    // Метод для переворачивания массива
    static void ReverseArray(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[length - i - 1];
            arr[length - i - 1] = temp;
        }
    }

    // Метод для печати массива
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
