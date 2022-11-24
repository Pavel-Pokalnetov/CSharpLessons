/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


long Akkerman(long m,long n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}


int[][] data = new int[][]
{
    new int[] {2,3},
    new int[] {3,2}
};
foreach (int[] item in data)
{
    Console.WriteLine($"m = {item[0]}; m = {item[1]}  ->  A(m,n) = {Akkerman(item[0], item[1])}");
}