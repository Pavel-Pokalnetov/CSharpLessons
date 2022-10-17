internal class Program
{
	private static void Main()
	{
		int rndInt = new Random().Next(100, 1000);
		int result = (rndInt % 100) / 10;
		Console.WriteLine($"{rndInt} , {result}");
	}
}
