internal class Program
{
    private static int getNumInPos(int num, int pos) //возвращает цифру в определенной позиции ( нумерация с 0)
    {
        int numLen = count10(num) - 1;
        int currentPos = numLen;
        if (numLen < pos)
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
    private static int count10(int x)//число цифр в числе
    {
        int t = 1;
        while (x > 10)
        {
            x = x / 10;
            t++;
        }
        return t;
    }

    private static string checkPolindrom(int num)//проверка на палиндром (да/нет)
    {
        if (num < 0) return "нет";
        int numLen = count10(num);
        for (int i = 0; i < numLen; i++) if (getNumInPos(num, i) != getNumInPos(num, numLen - 1 - i)) return "нет";
        return "да";
    }

    private static void Main(string[] args)
    {
        int number;Console.Write("Введите число (0 для выхода): ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine($"{number} -> {checkPolindrom(number)}");
    }
}