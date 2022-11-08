internal class Program
{
    private static void PrintChar(char sumbol,int count,ConsoleColor color) 
    {
        for (int i = 0; i < count; i++)
        {   
            if (color == ConsoleColor.Green && new Random().Next(0,10)>7)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else Console.ForegroundColor = color;
            Console.Write(sumbol);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }

    private static void PrintLine(int line, ConsoleColor color,int height,int offset)
    {
        int whitespace = height - 1 - line;;
        int stars = (line + 1) * 2 - 1;

        PrintChar(' ', offset,color);
        PrintChar(' ', whitespace, color);
        PrintChar('*', stars, color);
        Console.WriteLine();
        //Console.ResetColor();
    }


    public static void Main(string[] args)
    {
        Console.Write("Какова высота елочки: ");
        int heightChristmasTree = int.Parse(Console.ReadLine());
        Console.Clear();

        if (heightChristmasTree > 40){Console.WriteLine("Елка слишком высока"); return;}
        else if (heightChristmasTree <= 0) { Console.WriteLine("Таких елок не бывает");return;}

        int widthChristmasTree = heightChristmasTree * 2 - 1;
        int offset = (Console.WindowWidth - widthChristmasTree)/2;
        do
        {
            Console.SetCursorPosition(0,0);

            PrintLine(0, ConsoleColor.Red, heightChristmasTree, offset );//звезда-верхушка
            for (int row = 0; row < heightChristmasTree; row++)
            {
                PrintLine(row, ConsoleColor.Green, heightChristmasTree, offset);
            }
            PrintLine(0, ConsoleColor.DarkGray, heightChristmasTree, offset);//ствол
            PrintLine(0, ConsoleColor.DarkGray, heightChristmasTree, offset);

            System.Threading.Thread.Sleep(700);
        } while (true);



    }
}