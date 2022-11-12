/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

using System.Threading.Tasks.Dataflow;

internal class Program
{
    private static String ArrayToString(int[] array)
    {
        return "["+String.Join(", ", array)+"]";
    }
    
    private static int CheckParityCount(int[] array)
    {
        int count = 0;
        foreach (int elenentOfArray in array)
        {
            count += elenentOfArray % 2 == 0 ? 1 : 0;
        }
        return count;
    }

    private static int[] GetArray(int dim, int min, int max)
    {
        Random rnd = new Random();
        int[] array = new int[dim]; 
        for(int count = 0; count < dim; count++) { array[count] = rnd.Next(min,max+1);}
        return array;
    }
    
    private static void Main(string[] args)
    {
        int[] myArray = GetArray(4, 100, 999);
        Console.WriteLine($"{ArrayToString(myArray)} -> {CheckParityCount(myArray)}");

    }
}