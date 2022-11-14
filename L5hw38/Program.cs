/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76*/
internal class Program
{
    private static void Main(string[] args)
    {
        double[] myArray = GetArrayDouble(5, 0, 100);
        Console.WriteLine($"{ArrayToString(myArray)} -> {GetArrayDiffMinMax(myArray,GetArrayIndexMin(myArray),GetArrayIndexMax(myArray)):F2}");
    }

    private static String ArrayToString(double[] array)
    {
        String res = "[";
        for (int i = 0; i < array.Length; i++)
        {
            res += (i + 1) == array.Length ? $"{array[i]:f2}" : $"{array[i]:f2} ";
        }
        return res+"]";
    }

    private static double GetArrayDiffMinMax(double[] array, int min, int max)
    {
        return array[max] - array[min];
    }

    private static double[] GetArrayDouble(int dim, double min, double max)
    {
        Random rnd = new Random();
        double[] array = new double[dim];
        for (int count = 0; count < dim; count++) { array[count] = min + rnd.NextDouble() * (max-min); }
        return array;
    }

    private static int GetArrayIndexMin(double[] array)
    {
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[index]) { index = i; }

        }
        return index;
    }

    private static int GetArrayIndexMax(double[] array)
    {
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[index]) { index = i; }

        }
        return index;
    }
}