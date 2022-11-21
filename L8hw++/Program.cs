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

double Accuracy(int arg)
{   //коэфф. для оценки точности
    double accuracy = 1;
    for (int i = 0; i <= arg; i++) { accuracy /= 10.0; }
    return accuracy;
}
double sqrtHeron(double source, int acc)
{
    /* 
     * Формула Герона https://ru.wikipedia.org/wiki/Итерационная_формула_Герона
     */
    double accuracy = Accuracy(acc);
    double Xnew = (double)source;
    double Xold;
    int n = 1;
    do
    {
        Xold = Xnew;
        Xnew = (Xold + source / Xold) / 2;
        Console.WriteLine($"итерация {n} -> {Xnew}");n++;
    }
    while (Abs(Xnew - Xold) >= accuracy);
    return Xnew;
}


double sqrtIteration(double source, int acc)
{   /*
     * Метод итераций последовательными приближениями через золотое сечение 
     */
    double accuracy = Accuracy(acc);
    double X0 = 0, X1 = 10;
    double X;
    while (X1 * X1 < source)
    {
        X1 *= X1;
    }
    int n = 1;
    do
    {
        X = X0 + (X1 - X0)/ 1.6180339887498948482;
        Console.WriteLine($"итерация {n} -> {X}");n++;
        if (X * X == source) { return X; }
        if (X * X > source) { X1 = X; } else { X0 = X; }
    }while (Abs(X-(X0+X1)/2) > accuracy);
    return X;
}




Console.Write("Введите число: ");
double inputNumber = double.Parse(Console.ReadLine()!);
Console.Write("Точность (знаков после запятой): ");
int accuracy = int.Parse(Console.ReadLine()!);
Console.WriteLine($"метод Герона: {sqrtHeron(inputNumber, accuracy)}");
Console.WriteLine($"метод итераций: {sqrtIteration(inputNumber,accuracy)}") ;



