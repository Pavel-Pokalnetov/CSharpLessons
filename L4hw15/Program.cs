internal class Program
{
    private static void Main()
    {
        int number;
        Console.Write("Введите число: ");
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("введено не число,или что-то пошло не так");
            return;
        }
        if (number > 7 || number < 1) { Console.WriteLine("таких чисел дня недели не бывает)))"); return; }
        Console.WriteLine((number > 5 & number < 8) ? "да" : "нет");
    }
}