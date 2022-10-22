internal class Program
{
   static double Input(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }
    static double GetLenAB(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }
    public static void Main()
    {
        Console.WriteLine("Точка А");
        double x1 = Input("x=");
        double y1 = Input("y=");
        double z1 = Input("z=");
        Console.WriteLine("Точка B");
        double x2 = Input("x=");
        double y2 = Input("y=");
        double z2 = Input("z=");
        Console.Clear();
        Console.WriteLine($"A({x1},{y1},{z1});B({x2},{y2},{z2}) -> {GetLenAB(x1, y1, z1, x2, y2, z2),0:F2}");
    }
}