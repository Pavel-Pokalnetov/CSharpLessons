/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:  
2 4 | 3 4  
3 2 | 3 3  

Результирующая матрица будет:  
18 20  
15 18 

шпаргалка:
https://disshelp.ru/blog/wp-content/uploads/2020/09/word-image-12.png
https://disshelp.ru/blog/chto-takoe-matritsy-i-chto-s-nimi-delat/

*/
using MyLib;// библиотека с классом Function и методами GetArray, PrintArray 

int[,] MatrixMultiplication(int[,] A, int[,] B)
{   /// |A| x |B| = |C|
    int rowsA = A.GetLength(0);
    int colsA = A.GetLength(1);
    int rowsB = B.GetLength(0);
    int colsB = B.GetLength(1);
    if (rowsA != rowsB)
    {
        throw new ArgumentException("число строк в матрицах не равно\n" +
                                    "произведение выполнить невозможнo\n\n");
    }

    int rowsC = rowsA;

    int colsC = (colsA > colsB) ? colsB : colsA;
    bool flag = (colsA > colsB);
    //эта конструкция нужна чтобы можно было умножать матрицы с разным количеством столбцов


    int[,] C = new int[rowsC, colsC];

    for (int i = 0; i < rowsC; i++)
    {
        for (int j = 0; j < colsC; j++)
        { // C[i,j]
            C[i, j] = 0;
            for (int k = 0; k < rowsB; k++)
            {
                C[i, j] += (flag) ? (A[i, k] * B[k, j]) : A[k, j] * B[i, k];
            }
        }
    }
    return C;
}

/**************************************************************/

int[,] matrixA = Function.GetArray(2, 2, 1, 9);
int[,] matrixB = Function.GetArray(2, 2, 1, 9);

/* пример из задания
int[,] matrixB = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] matrixA = new int[2, 2] { { 3, 4 }, { 3, 3 } };
*/

Function.PrintArray(matrixA);
Console.WriteLine(" - - - - - - ");
Function.PrintArray(matrixB);
Console.WriteLine(" - - - - - - ");
int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
Function.PrintArray(matrixC);


