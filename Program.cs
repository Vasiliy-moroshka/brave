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

int number = 947;
int secondDigit = number / 10 % 10; // 947 / 10 % 10 = 94 % 10 = 4
int thirdDigit = number % 10; // 947 % 10 = 7
// Math.Pow(5, 2) = 5*5 = 25
int result = (int)Math.Pow(secondDigit, thirdDigit);
// результат переводится в (int)
Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");
