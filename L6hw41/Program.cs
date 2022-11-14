/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

-0, 7, 8, -2, -2-> 2
- 1, -7, 567, 89, 223-> 3 */

int[] myArray = InputArray();
Console.WriteLine($"{ArrayToString(myArray)} -> {GetPisitiveCount(myArray)}");


/* вывод консоли
 Введите массив из N чисел, разделяя запятыми: -0,7,8,-2,-2
[0, 7, 8, -2, -2] -> 2

Введите массив из N чисел, разделяя запятыми: -1,-7,567,89,223
[-1, -7, 567, 89, 223] -> 3
 */



int GetPisitiveCount(int[] array) //количество элементов >0
{
    int count = 0;
    foreach (int item in array) { if (item > 0) count++; }
    return count;
}

int[] InputArray() //ввод с массива в консоли одной строкой
{
    Console.Write("Введите массив из N чисел, разделяя запятыми: ");
    string[] numbers = Console.ReadLine()!.Trim(' ',',').Split(",");
    int[] array = new int[numbers.Length];
    int i = 0;
    foreach (var item in numbers)
    {
        array[i] = Convert.ToInt32(item); i++;
    }
    return array;
}
String ArrayToString(int[] array) { return "[" + String.Join(", ", array) + "]"; }