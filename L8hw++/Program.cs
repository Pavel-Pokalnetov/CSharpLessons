/*
 ### L8++ -\> Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
Нельзя использовать встроенные функции библиотеки Math!
 */
using System.Numerics;

double Abs(double arg)
{   //модуль числа
    return arg < 0 ? -arg : arg;
}

double sqrtHeron(double source)
{
    /* 
     * Формула Герона https://ru.wikipedia.org/wiki/Итерационная_формула_Герона
     */
    if (source == 1) { return 1; }
    double Xnew = (double)source;
    double Xold;
    int n = 1;
    do
    {
        Xold = Xnew;
        Xnew = (Xold + source / Xold) / 2;
        Console.WriteLine($"итерация {n} -> {Xnew}"); n++;
    }
    while (Abs(Xnew - Xold) != 0);
    return Xnew;
}


bool isFoundNumber(ulong n, ulong source)
{
    if (n * n <= source && (n + 1) * (n + 1) > source) { return true; }
    return false;
}
ulong sqrt(ulong sourse)
{   //двоичный поиск
    if (sourse == 1) { return 1;}
    ulong res = 1, res0 = 1;
    int n = 1;
    while (res * res <= sourse)
    {
        res0 = res;
        res = res<<2;
        Console.WriteLine($"итерация {n} -> {res}"); n++;
    }
    if (isFoundNumber(res, sourse)) { return res; }
    ulong midle;
    while (res-res0>0)
    {
        midle = (res0 + res) / 2;
        Console.WriteLine($"итерация {n} -> {midle}"); n++;
        if (isFoundNumber(midle, sourse)) { return midle; }
        if (midle * midle > sourse)
        {
            res=midle;
        }
        else
        {
            res0=midle;
        }    
    }
    return res;
}




do
{
    Console.Write("Введите число: ");
    double inputNumber = double.Parse(Console.ReadLine()!);
    if (inputNumber == 0) return;
    Console.Clear();
    Console.WriteLine($"метод Герона {inputNumber}\n");
    Console.WriteLine($"\nрезультат: {sqrtHeron(inputNumber)}");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine($"\n\nметод итераций по целым {inputNumber}\n");
    Console.WriteLine($"\nрезультат: {sqrt((ulong)inputNumber)}\n\n");

}while(true);   



/* решение столбиком */

