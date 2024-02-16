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
//         while(number > 0) // Вычисление суммы цифр числа
//         {
//         sum += number % 10; // Добавление последней цифры к сумме
//         number /= 10; // Удаление последней цифры из числа
//         }
//         if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
//         {
//         Console.WriteLine("[STOP]");
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