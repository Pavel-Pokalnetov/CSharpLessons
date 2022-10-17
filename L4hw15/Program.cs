internal class Program
{
    private static void Main()
    {
        int number;
        Console.Write("Введите число: ");
        try
        {
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((number > 0 & number < 8) ? "да" : "нет");
            /* или тоже самое в записи if-else
                if (number>0 & number<8){
                    Console.WriteLine("да");    
                } else {
                    Console.WriteLine("нет");
                }
            */
        }
        catch
        {
            Console.WriteLine("введено не число,или что-то пошло не так");
        }
    }
}