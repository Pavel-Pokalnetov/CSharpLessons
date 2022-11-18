/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

 */

double[,] GetArray(int dimA, int dimB, double minVal, double maxVal)
{
    Random rnd = new Random();
    double[,] array = new double[dimA, dimB];
    for (int i = 0; i < dimA; i++)
    {
        for (int j = 0; j < dimB; j++)
        {
            array[i, j] = rnd.NextDouble() * (maxVal - minVal) + minVal;
        }
    }
    return array;
}

void PrintDoubleArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j],5:F1} ");
        }
        Console.WriteLine();
    }
}

PrintDoubleArray(GetArray(3, 3, 0, 100));