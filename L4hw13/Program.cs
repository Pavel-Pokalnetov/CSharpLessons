internal class Program
{
    private static bool IsInt32(string check)// return True if check is int32 number
    {
        try
        {
            int temp = Convert.ToInt32(check);
            return true;
        }
        catch
        {
            return false;
        }
    }
    private static void Main()
    {
        Console.Write("Введите число: ");
        string number = Console.ReadLine();
        if (IsInt32(number))
        {
            if (number.Length > 2)
            {
                Console.WriteLine(number[2]);
            }
            else
            {
                Console.WriteLine("третьей цифры нет");
            }
        }
        else
        {
            Console.WriteLine("введено не число");
        }

    }
}
