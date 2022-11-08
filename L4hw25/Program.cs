/*
 Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 я расширил задание, и алгоритм позволяет возводить в степень любые целые числа из диапазона int
 */

internal class Program
{
    private static int Abs(int number)
    {
        if (number < 0) return number * -1;
        return number;
    }

    public static double Expo(int A, int B)
    {
        //проверка входных данных
        if (B == 0) return 1;  //если показатель степени равно 0
        if (A == 0) return 0; //если основание равно 0
        double res = A;
        for (int i = 2; i <= Abs(B); i++)
        {
            res *= A;
        }
        if (B < 0) return 1 / res; //если показатель степени отрицательный
        return res;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите 2 числа через запятую");
        string[] numbers = Console.ReadLine().Split(",");
        Console.WriteLine(Expo(int.Parse(numbers[0]), int.Parse(numbers[1])));
    }
}