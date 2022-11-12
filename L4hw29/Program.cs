internal class Program
{
    private static void ArrayPrint(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write((i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}");
        }
        Console.Write("]");
    }

    private static int[] ArrayInput()
    {   
        Console.Write("Введите массив из 8 чисел, разделяя запятыми: ");
        do
        {
            string[] numbers = Console.ReadLine().Trim(' ').Split(",");
            if (numbers.Length == 8)
            {
                int[] array = new int[numbers.Length];
                int i = 0;
                foreach (var item in numbers)
                {
                    array[i] = Convert.ToInt32(item); i++;
                }
                return array;
            }
            Console.Write("вы набрали какую то муть! поторите: ");
        } while (true);
        
    }

    private static void Main(string[] args)
    {
        ArrayPrint(ArrayInput());
    }
}