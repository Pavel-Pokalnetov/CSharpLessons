internal class Program
{
    private static int count10(int x)
    {
        int t = 1;
        while (x > 10)
        {
            x = x / 10;
            t++;
        }
        return t;
    }
    private static void Main()
    {
        int number;
        try
        {
            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("ошибка ввода"); return;
        }
        if (number < 100)
        {
            Console.WriteLine("3-й цифры нет");
            return;
        }
        int count = count10(number);
        while (count > 3)
        {
            number /= 10;
            count--;
        }
        number %= 10;
        Console.WriteLine(number);
    }
}
