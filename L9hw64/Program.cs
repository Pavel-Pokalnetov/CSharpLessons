/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

String NaturalNumbers(int N)
{
    if (N == 1) return N.ToString();
    return $"{N}, {NaturalNumbers(N - 1)}";
}


int[] data = new int[] { 5, 8 };
foreach (int item in data)
{
    Console.WriteLine($"N = {item,2} ->  \"{NaturalNumbers(item)}\"");
}