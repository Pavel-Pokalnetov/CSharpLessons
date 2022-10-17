internal class Program
    {
        private static void Main(string[] args)
        {
            // --------- Задание 1.6 ---------
            Console.Write("Введите число :");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 != 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("число нечетное");
            }
        }
    }
