// Напишите программу, которая 
// принимает на вход трехзначное число 
// и удаляет вторую цифру этого числа.
// Приимеры 
// a = 256 => 26
// b = 891 => 81

int number = 563;
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;

// $"Текст {result} текст {a - 100} текст {a + 400}"

Console.WriteLine($"В числе {number} => {result}");