// Напишите программу, которая 
// принимает на вход трехзначное число 
// и удаляет вторую цифру этого числа.
// Приимеры 
// a = 256 => 26
// b = 891 => 81

// int number = 563;
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;

// // $"Текст {result} текст {a - 100} текст {a + 400}"

// Console.WriteLine($"В числе {number} => {result}");

// Напишите программу, которая принимает
// на вход трехзначное число и возводит вторую цифру этого числа в степень,
// равную третьей цифре.

// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625

// int number = 947;
// int secondDigit = number / 10 % 10; // 947 / 10 % 10 = 94 % 10 = 4
// int thirdDigit = number % 10; // 947 % 10 = 7
// // Math.Pow(5, 2) = 5*5 = 25
// int result = (int)Math.Pow(secondDigit, thirdDigit);
// // результат переводится в (int)
// Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");



// Напишите программу, которая выводит
// третью цифру с конца заданного числа 
// или сообщает, что третьей цифры нет.
// Примеры
// 456 => 4
// 7812 => 8
// 91 => третьей цифры нет


// int number = 92;
// if(number >= 100)
// {
//     int thirdDigitFromEnd = number / 100 % 10;
//     Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}");
// } 
// else // в числе нет третьей цифры
// {
//     Console.WriteLine("Третьей цифры нет");
// }


// int a = 6;
// int b = 2;

// if(a % b == 0)
// {
//     Console.WriteLine($"{a} кратно (делится без остатка) числу {b}");
// }
// else
// {
//     Console.WriteLine($"Остаток от {a} / {b} = {a % b}");
// }

