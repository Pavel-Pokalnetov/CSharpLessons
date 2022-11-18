/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */


int[,] GetArray(int dimA, int dimB, int minVal, int maxVal)
{
    Random rnd = new Random();
    int[,] newArray = new int[dimA, dimB];
    for (int i = 0; i < dimA; i++)
    {
        for (int j = 0; j < dimB; j++)
        {
            newArray[i, j] = rnd.Next(minVal, maxVal);
        }
    }
    return newArray;
}


void PrintIntArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j],5} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumnArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
        }
        summ /= array.GetLength(0);
        Console.Write($"{summ,5} ");
    }
}

int[,] myArray = GetArray(4, 4, -10, 10);
PrintIntArray(myArray);
Console.WriteLine("   --------------------");
ArithmeticMeanColumnArray(myArray);
