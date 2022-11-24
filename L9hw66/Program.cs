/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Summ(int M, int N)
{
    if (N == M) return N;
    return N + Summ(M,N - 1);
}



/* test */
int[][] data = new int[][]
{
    new int[] {1,15},
    new int[] {4,8}
};
foreach (int[] item in data)
{
    Console.WriteLine($"M = {item[0],2}; N = {item[1],2}  ->  {Summ(item[0], item[1]),3}");
}