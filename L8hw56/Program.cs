/*  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

 */

using MyLib;

int getSummRow(int[,] array, int row)
{///возвращает сумму элементов строки #row двумерного массива
    int summ = array[row, 0];
    for (int i = 1; i < array.GetLength(1); i++)
    {
        summ += array[row, i];
    }
    return summ;
}

int rowWithMinElement(int[,] array)
{///возвращает номер(индекс) строки с наименьшей суммой элементов
    int dimRow = array.GetLength(0);
    int dimCol = array.GetLength(1);
    int rowWithSmallElement = 0;
    int smallElement = getSummRow(array, 0);
    for (int row = 1; row < dimRow; row++)
    {   
        if (smallElement > getSummRow(array, row))
        {
            rowWithSmallElement = row;
            smallElement = getSummRow(array, row);
        }
    }
    return rowWithSmallElement;
}

int[,] testArray = Function.GetArray(4, 4, 0, 9);
Function.PrintArray(testArray);
Console.WriteLine();
int row = rowWithMinElement(testArray);
Console.WriteLine($"Строка с минимальной суммой элементов: {row}");
