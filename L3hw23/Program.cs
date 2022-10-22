internal class Program
{
    static int Input(string prompt)//ввод с консоли
    {
        Console.Write(prompt + " ");
        return int.Parse(Console.ReadLine());
    }
    static double Pow3(int arg) { return Math.Pow(arg, 3); }//вычисление куба числа
    static string CubeRange(int n)//получение ряда кубов чисел от 1 до n
    {
        string result = "";
        for (int i = 1; i <= n; i++)
        {
            result += Pow3(i).ToString() + ((i != n) ? ", " : "");
        }
        return result;
    }
    private static void Main()
    {
        int N = Input("Введите N:");
        Console.WriteLine($"{N} -> {CubeRange(N)}");
    }
}