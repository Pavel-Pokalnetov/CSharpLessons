internal class Program
{   
    private static int getNumInPos(int num, int pos)
    {//возвращает цифру в определенной позиции
        int numLen = count10(num);
        int currentPos = numLen;
        while (currentPos!= numLen && currentPos > 0)
        {
            num /= 10;
            currentPos--;
        }
        num %= 10;
        return num;
    }
    private static int count10(int x)
    {//число цифр в числе
        int t = 1;
        while (x > 10)
        {
            x = x / 10;
            t++;
        }
        return t;
    }

    private static void Main(string[] args)
    {
        int number;
        while (true)
        {
            Console.Write("Введите число (0 для выхода): ");
            number = int.Parse(Console.ReadLine());
            if (number == 0) break;

            bool flag = false;
            for (int i = 1; i <= count10(number); i++)
            {

            }


        }
    }
}