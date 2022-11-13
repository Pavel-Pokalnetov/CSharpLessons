/* Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6]-> 0
 */
using System.Security.Cryptography;

internal class Program
{
    public static void Main(string[] args){
        int[] myArray = GetArray(4, -99, 99);
        Console.WriteLine($"{ArrayToString(myArray)} -> {GetSumOddElenents(myArray)}");

        /* для теста. пример из задания
        myArray = new int[4] { 3, 7, 23, 12 };
        Console.WriteLine($"{ArrayToString(myArray)} -> {GetSumOddElenents(myArray)}");
        myArray = new int[4] { -4, -6, 89, 6 };
        Console.WriteLine($"{ArrayToString(myArray)} -> {GetSumOddElenents(myArray)}");
        */
    }

    private static String ArrayToString(int[] array)
    {
        return "[" + String.Join(", ", array) + "]";
    }

    private static int[] GetArray(int dim, int min, int max)
    {
        Random rnd = new Random();
        int[] array = new int[dim];
        for (int count = 0; count < dim; count++) { array[count] = rnd.Next(min, max + 1); }
        return array;
    }

    private static int GetSumOddElenents(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2){sum+=array[i];}
        return sum;
    }
}