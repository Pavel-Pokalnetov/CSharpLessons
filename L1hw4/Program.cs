internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите 3 числа, A B C");
        Console.Write("Введите число A:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите чило B:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите чило C:");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a > b & a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}
