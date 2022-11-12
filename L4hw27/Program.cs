/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */
internal class Program
{
    private static int SumOfDigits(int number)
    {
        int result = 0;
        do
        {
            result += number % 10;
            number /= 10;
        } while (number > 0);
        return result;
    }

    public static void Main(string[] args)
    {
        int number;
        Console.Write("Вводите числа (0 для выхода)");
        do
        {
            number = int.Parse(Console.ReadLine());
            if (number == 0) return;
            Console.WriteLine($"{number} -> {SumOfDigits(number)}");
        } while (true);
    }
}