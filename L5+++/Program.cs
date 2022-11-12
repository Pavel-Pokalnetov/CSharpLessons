/*Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
    [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
    [1, 2, 2, 3, 2] -> [3, 2, 2, 2, 1]
*/
internal class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = GetArray(10, 0, 10);
        Console.Write(ArrayToString(myArray) + " -> ");
        myArray = ArraySort(myArray);
        Console.WriteLine(ArrayToString(myArray));

        /*для проверки по массивам из задания
        int[] myArray = new int[5] { 3, 0, 2, 4, -1 };
        Console.Write(ArrayToString(myArray) + " -> ");
        myArray = ArraySort(myArray);
        Console.WriteLine(ArrayToString(myArray));

        myArray = new int[5] { 1, 2, 2, 3, 2 };
        Console.Write(ArrayToString(myArray) + " -> ");
        myArray = ArraySort(myArray);
        Console.WriteLine(ArrayToString(myArray));
        */
    }

    private static int[] ArraySort(int[] array)
    {
        bool arayIsSorted;
        do
        {
            arayIsSorted = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                //if (array[i] > array[i + 1]) //возрастающая
                if (array[i] < array[i + 1]) //убывающая
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    arayIsSorted = false;
                }
            }
        } while (!arayIsSorted);
        return array;
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
}