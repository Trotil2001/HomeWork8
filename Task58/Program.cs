/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
2*3+4*3 2*4+4*3
3*3+2*3 3*4+2*3
Результирующая матрица будет:
18 20
15 18
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            //Console.Write(matrix[i, j] + " \t");
            Console.Write("{0,5}", matrix[i, j]);
        Console.WriteLine();
    }
}

int[,] ReleaseMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC=new int[matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k=0;k<matrixB.GetLength(0);k++)
                matrixC[i,j]=matrixC[i,j]+matrixA[i,k]*matrixB[k,j];
        }
    }
return matrixC;
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[n, m];
int[,] matrixB = new int[m, n];
InputMatrix(matrixA);
Console.WriteLine("Исходный двумерный массив A: ");
PrintMatrix(matrixA);
InputMatrix(matrixB);
Console.WriteLine("Исходный двумерный массив B: ");
PrintMatrix(matrixB);
Console.WriteLine("Результирующий массив C: ");
//ReleaseMatrix(matrixA,matrixB);
PrintMatrix(ReleaseMatrix(matrixA,matrixB));