// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


// void ShowNumbers(int M, int N)
// {
//     if(M == N)
//     {
//         Console.Write(M);
//         return;
//     }
//     Console.Write(M + " ");
//     ShowNumbers(M + 1, N);
// }

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(M, N);


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


// int Ackermann(int m, int n)
// {
//     if(m == 0) 
//     {
//         return n + 1;
//     }
//     else if(n == 0) 
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else 
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }

// Console.Write(Ackermann(3, 2));


// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


int[] CreateArray(int size)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    // if(int i == array.Length)
    // {

    // }
    return array;
}


void PrintReverseArray(int[] array, int j)
{
    if(j == 0)
    {
        Console.Write(array[j]);
        return;
    } 
        Console.Write(array[j] + "; ");
        PrintReverseArray(array, j - 1);
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.Write($"Результат: ");
PrintReverseArray(array, size - 1);