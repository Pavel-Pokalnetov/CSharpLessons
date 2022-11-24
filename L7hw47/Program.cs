/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

 */

double[,] GetArray(int dimA, int dimB, double minVal, double maxVal)
{
    Random rnd = new Random();
    double[,] newArray = new double[dimA, dimB];
    for (int i = 0; i < dimA; i++)
    {
        for (int j = 0; j < dimB; j++)
        {
            newArray[i, j] = rnd.NextDouble() * (maxVal - minVal) + minVal;
        }
    }
    return newArray;
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


Console.WriteLine("Задайте размерность массива");
Console.Write("число строк m=");
int m = int.Parse(Console.ReadLine());
Console.Write("число колонок n=");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("задайте диапазон значений элементов массива (min;max)");
Console.Write("min=");
int min = int.Parse(Console.ReadLine());
Console.Write("max=");
int max = int.Parse(Console.ReadLine());
Console.WriteLine();
double[,] myArray = GetArray(m,n, min,max);
PrintDoubleArray(myArray);