/*Задача со звездочкой: Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.

1 2 3
4 5 6 -> 7 8 9 6 3 2 1 4 5
7 8 9

 */
int[,] myArray = new int[,] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 7, 8, 9, 10 } };

Console.WriteLine(ArrayToStringMultyM(myArray));
Console.WriteLine(ArrayToString(ZigzagArrayIteration(myArray)));



//обход массива
int[] ZigzagArrayIteration(int[,] array)
{
    int width = array.GetUpperBound(1) + 1;//ширина исходного массива
    int height = array.GetUpperBound(0) + 1;//высота исходного массива
    int[] result = new int[width * height];//итоговый одномерный массив
    int col = 0, index = 0, delta = 1;
    for (int row = height - 1; row >= 0; row--)
    {//перебор строк
        while (col >= 0 && col < width)
        {//обход строки по элементам в направлении delta 
            result[index] = array[row, col];
            col += delta;
            index++;
        }
        if (delta > 0 && col == width)
        {//разворот обхода строки в <<<<<
            col -= 1;
            delta = -1;
            continue;
        }
        if (delta < 0 && col < 0)
        {//разворот обхода в >>>>>>
            col = 0;
            delta = 1;
            continue;
        }
    }

    return result;
}

String ArrayToString(int[] array) { return "[" + String.Join(", ", array) + "]"; }//

String ArrayToStringMultyM(int[,] array)
{
    string result = "";
    int width = array.GetUpperBound(1) + 1;//ширина исходного массива
    int height = array.GetUpperBound(0) + 1;//высота исходного массива
    for (int row = 0; row < height; row++)
    {
        for (int col = 0; col < width; col++)
        {
            result += $"{array[row, col]}" + ((col < width) ? "," : "");
        }
        result += "\n";
    }
    return result;
}