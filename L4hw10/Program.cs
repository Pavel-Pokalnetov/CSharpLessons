internal class Program
{
	private static bool IsInt32(string checkSymbol)
	{
		try
		{
			int temp = Convert.ToInt32(checkSymbol);
			return true;
		}
		catch
		{
			return false;
		}
	}
	private static void Main()
	{
		Console.Write("Введите 3х-значное число: ");
		string number = Console.ReadLine();
		if (IsInt32(number)){
			if (number.Length == 3){
				Console.WriteLine(number[1]);
				return;}
			Console.WriteLine("число не трехзначное");
			return;
		}
		Console.WriteLine("введено не число");
		
		
		
	}
}
