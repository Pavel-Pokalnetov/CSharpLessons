internal class Program
{
	static void Main(string[] args)
	{
		// --------- Задание 1.2 ---------
		Console.Write("Введите число A:");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Введите чило B:");
		int b = Convert.ToInt32(Console.ReadLine());
		if (a > b)
		{
			Console.WriteLine("Число А > B");
		}
		else if (b > a)
		{
			Console.WriteLine("Число B>A");
		}
		else
		{
			Console.WriteLine("Число равны");
		}
	}
}