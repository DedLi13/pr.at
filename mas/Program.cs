// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void PrintNaturalNumbers(int m, int n)
//     {
//         if (m > n)
//         {
//             return;
//         }

//         Console.Write(m + " ");
//         PrintNaturalNumbers(m + 1, n);
//     }

//     static void Main()
//     {
//         // Введите значения M и N
//         Console.Write("Введите значение M: ");
//         int M = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int N = Convert.ToInt32(Console.ReadLine());

//         // Вызываем функцию для вывода натуральных чисел
//         PrintNaturalNumbers(M, N);
//     }
// }


// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }

//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int result = Ackermann(m, n);
//         Console.WriteLine($"Значение функции Аккермана для A({m}, {n}) = {result}");
//     }
// }


// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void PrintArrayReversed(int[] arr, int index)
//     {
//         if (index < 0 || index >= arr.Length)
//         {
//             return;
//         }

//         Console.Write(arr[index] + " ");
//         PrintArrayReversed(arr, index - 1);
//     }

//     static void Main()
//     {
//         // Произвольный массив
//         int[] myArray = { 4, 5, 7, 10, 36, 13};

//         Console.WriteLine("Элементы массива, начиная с конца:");
//         PrintArrayReversed(myArray, myArray.Length - 1);
//     }
// }
