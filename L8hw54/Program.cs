/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using MyLib;
/// библиотека с функциями 
/// int[,] GetArray(int row, int col, int minValue, int maxValue)
/// void PrintArray(int[,] printableArray)

/*
int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] resultArray = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            resultArray[i,j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}*/

void SortRowArray(int[,] sortedArray)
{
    int dimRow = sortedArray.GetLength(0);
    int dimCol = sortedArray.GetLength(1);
    for (int i = 0; i < dimRow; i++)
    {
        bool isSorted; int tempCell;
        do
        {
            isSorted = true;
            for (int j = 1; j < dimCol; j++)
            {
                if (sortedArray[i, j] > sortedArray[i, j - 1])
                {
                    tempCell = sortedArray[i, j];
                    sortedArray[i, j] = sortedArray[i, j - 1];
                    sortedArray[i, j - 1] = tempCell;
                    isSorted = false;
                }
            }
        } while (!isSorted);
    }
}

/*
void PrintArray(int[,] printableArray)
{
    int dimRow = printableArray.GetLength(0);
    int dimCol = printableArray.GetLength(1);
    for (int i = 0; i < dimRow; i++)
    {
        for (int j = 1; j < dimCol; j++)
        {
            Console.Write($"{printableArray[i, j],4} ");
        }
        Console.WriteLine();
    }
}
*/


int[,] myArray = Function.GetArray(6, 6, 0, 9);
Function.PrintArray(myArray);
Console.WriteLine("  -----------------------");
SortRowArray(myArray);
Function.PrintArray(myArray);


/*
Вывод консоли

   0    3    9    8    8
   7    5    4    7    6
   1    7    7    5    4
   6    4    5    3    9
   3    9    4    4    3
   7    6    8    8    4
  -----------------------
   8    8    3    0    0
   7    6    5    4    0
   7    5    4    4    1
   7    6    5    4    3
   4    4    4    3    3
   8    7    7    6    4

 */