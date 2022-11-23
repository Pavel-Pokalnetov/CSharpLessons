namespace MyLib
{
    public static class Function
    {
        public static void PrintArray(int[,] printableArray)
        {
            int dimRow = printableArray.GetLength(0);
            int dimCol = printableArray.GetLength(1);
            for (int i = 0; i < dimRow; i++)
            {
                for (int j = 0; j < dimCol; j++)
                {
                    Console.Write($"{printableArray[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] GetArray(int row, int col, int minValue, int maxValue)
        {
            int[,] resultArray = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
                }
            }
            return resultArray;
        }
    }
}