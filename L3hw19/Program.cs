internal class Program
{
    private static int getNumInPos(int num, int pos) //возвращает цифру в определенной позиции ( нумерация с 0)
    {
        int currentPos = 4;
        if (pos > 4)
        {
            throw new Exception("index out of range");
        }
        while (currentPos != pos && currentPos >= 0)
        {
            num /= 10;
            currentPos--;
        }
        num %= 10;
        return num;
    }

    private static string checkPolindrom(int num)//проверка на палиндром (да/нет)
    {
        if (num < 10000 || num > 99999)
        {
            Console.WriteLine("число вне диапазона 10000..99999");
            Environment.Exit(1); //Выход с кодом 1 если задано число не из 5-и цифр
        }
        for (int i = 0; i < 5; i++) if (getNumInPos(num, i) != getNumInPos(num, 4 - i)) return "нет";
        return "да";
    }

    private static void Main(string[] args)
    {
        foreach (int item in new int[] { 14212, 12821, 23432 })
        {
            Console.WriteLine($"{item} -> {checkPolindrom(item)}");
        }

    }
}