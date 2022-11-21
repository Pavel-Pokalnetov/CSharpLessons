double Abs(double arg)
{   //модуль числа
    return arg < 0 ? -arg : arg;
}

double Round(double arg, int acc)
{
    for (int i = 0; i < acc; i++)
    {
        arg *= 10;
    }
    arg = (int)arg;
    for (int i = 0; i < acc; i++)
    {
        arg /= 10;
    }
    return arg;
}

double funcionHeron(double source, int acc)
{
    /* 
     * Формула Герона https://ru.wikipedia.org/wiki/Итерационная_формула_Герона
     */
    double accuracy = 1.0;
    for (int i = 0; i < acc; i++) { accuracy /= 10.0; }
    
    double Xnew = (double)source;
    double Xold;

    do
    {
        Xold = Xnew;
        Xnew = (Xold + source/Xold)/2;
    }
    while (Abs(Xnew - Xold) >= accuracy);
    return Round(Xnew,acc);
}




Console.Write("Введите число: ");
double inputNumber = double.Parse(Console.ReadLine()!);
Console.Write("Точность (знаков после запятой): ");
int accuracy = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{funcionHeron(inputNumber,accuracy)}");