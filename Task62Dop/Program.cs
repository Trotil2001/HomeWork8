/*
Дополнительная задача
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = 0;
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


void ReleaseMatrix(int[,] matrix)
{
    int numbers = 1, i = 0, j = 0;
    int n = matrix.GetLength(0), m = matrix.GetLength(1);
    int round = 0; // счетчик витков
    for (int Elem = 0; Elem < n * m; Elem++)
    {
        matrix[i, j] = numbers++;
        if (i == round && j < m - round - 1)
            j++;
        else if (j == m - round - 1 && i < n - round - 1)
            i++;
        else if (i == n - round - 1 && j > round)
            j--;
        else
            i--;

        if ((i == round + 1) && (j == round)) 
        {
            round++;
        }
    }
}


Console.Write("Введите количество строк матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Исходный двумерный массив: ");
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Конечный двумерный массив: ");
PrintMatrix(matrix);