/*  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5,
b2 = 4, k2 = 9
(-0, 5; -0,5)
*/




double[] InputParam() // ввод параметров линейных уравнений прямых
{
    double[] res = new double[4];
    /*  [0] -> k1,
     *  [1] -> b1,
     *  [2] -> k2,
     *  [3] -> b2
     */
    int n = 1;
    for (int i = 0; i < 4; i += 2)
    {
        Console.WriteLine($"{n}-е уравнение y = k{n} * x + b{n}");
        Console.Write($" k{n} = "); res[i] = double.Parse(Console.ReadLine());
        Console.Write($" b{n} = "); res[i + 1] = double.Parse(Console.ReadLine());
        n++;
    }
    return res;
}

double[]? PointsIntersectionOfStraightLines(double[] arg)
{
    /*  
     *  вернет массив [x,y] или null массив с сообщением о причине
     *  
     *  arg[0] -> k1,
     *  arg[1] -> b1,
     *  arg[2] -> k2,
     *  arg[3] -> b2
     */

    if (arg[1] == arg[3] && arg[0] == arg[2]) //проверка на совпадение прямых k1=k2 и b1=b2
    {
        Console.WriteLine("Прямые совпадают. Точек пересечения бесконечное множество."); 
        return null;
    }
    if (arg[0] == arg[2])//проверка на параллельность k1=k2
    {
        Console.WriteLine("Прямые параллельны. Точек пересечения нет");
        return null;
    }


    //дальше вычисляем точку пересечения
    double[] res = new double[2]; //[x,y] 
    res[0] = (arg[3] - arg[1]) / (arg[0] - arg[2]);  //x
    res[1] = arg[0] * res[0] + arg[1];
    return res;
}


double[] parametryStraightLine = InputParam();
double[] point = PointsIntersectionOfStraightLines(parametryStraightLine);
if (point is null) return;
Console.WriteLine($"Точка пересечения ( {point[0]:F1} , {point[1]:F1} )");

/* вывод консоли

1-е уравнение y = k1 * x + b1
 k1 = 5
 b1 = 2
2-е уравнение y = k2 * x + b2
 k2 = 9
 b2 = 4
Точка пересечения ( -0,5 , -0,5 )
  
 */