// Задача 1: Задайте двумерный массив 
// символов (тип char [,]). Создать 
// строку из символов этого массива.

// string GetStringFromCharArray(char[,] array)
// {
//     string result = string.Empty; // Create a variable result with empty string
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i, j]; // save in result letter one by one
//         }
//     }
//     return result;
// }

// char[,] charMatrix = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } }; // Create array
// Console.WriteLine($"Исходный массив: {charMatrix}"); // Error! Don't know where
// string res = GetStringFromCharArray(charMatrix); // Appeal to function
// Console.WriteLine($"Строчка: {res}"); // Print result


// Задача 2: Задайте строку, содержащую латинские 
// буквы в обоих регистрах. Сформируйте строку, 
// в которой все заглавные буквы заменены на строчные.


// Console.WriteLine("Введите пожалуйста строку: ");
// string inputString = Console.ReadLine();
// Console.WriteLine(inputString.ToLower());


// Задача 3: Задайте произвольную строку.
//  Выясните, является ли она палиндромом.


// string IsPalindrom(string str)
// {
//     string result = string.Empty;
//     for(int i = 0, j = str.Length -1; i < str.Length; i++, j--) // Создание цикла с двумя индексами от первого и последнего
//     {
//         if(str[i] != str[j]) // Проверка: первый символ НЕ равен последнему, второй - предпоследнему, и так далее
//         {
//         result = "Символы совпали не полностью. Строка не палиндром"; // Если проверка ложная
//         break; // Ломаем цикл
//         }
//         else
//         {
//         result = "Все символы совпали. Строка палиндром";
//         }
        
//     }
//     return result; // Возвращает строку, не нужное действие, как это поменять
// }

// Console.WriteLine("Пожалуйста введите строку: ");
// string Palindrom = Console.ReadLine();
// Console.WriteLine(IsPalindrom(Palindrom));


Задача 4*(не обязательная): Задайте строку, 
состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены 
в обратном порядке. В полученной строке слова 
должны быть также разделены пробелами.


// char[] GetReverseString(string str)
// {
//     char[] reversedString = new char[str.Length];
//     for(int i = 0; i < str.Length; i++)
//     {
//         reversedString[i] = str[str.Length -1];
//     }
//     return reversedString;
// }

// Console.WriteLine("Введите пожалуйста строку: ");
// string str = Console.ReadLine();
// char[] reversedString = GetReverseString(str);
// Console.WriteLine(reversedString);
