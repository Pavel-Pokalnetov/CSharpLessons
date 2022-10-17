internal class Program
{
	private static void Main(string[] args)
	{
		// --------- Задание 1.8 ---------
		Console.Write("Введите число N (от 1 до ...) :");
		int a = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i < a; i++)
		{
			if (i % 2 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
