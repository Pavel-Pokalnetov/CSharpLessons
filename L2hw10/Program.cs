internal class Program
{
	private static void Main()
	{
		int cnsEnter = 0;
		try
		{   //проверка на правильный ввод через исключения
			Console.Write("Введите число: ");
			cnsEnter = int.Parse(Console.ReadLine());
			if (cnsEnter < 100 || cnsEnter > 999) throw new Exception();
		}
		catch
		{
			Console.WriteLine($"ввдена не цифра или введено число не из диапазона 100...999");
			return;
		}

		//	int result = (cnsEnter % 100) / 10;
		Console.WriteLine($"исходное число: {cnsEnter}, средняя(2я) цифра: {(cnsEnter % 100) / 10}");
	}
}
