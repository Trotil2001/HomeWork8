/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void InputMatrix(int[,,] matrix)
{
    int numbers=10;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = numbers++;
}

void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.WriteLine(matrix[i, j, k] + " (" + i + ", " + j + ", " + k + ")");
    }
}

Console.Write("Введите размер квадратной матрицы N не больше 4: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<2||n>4)
{
Console.Write("Введите размер квадратной матрицы N не больше 4: ");
n = Convert.ToInt32(Console.ReadLine());
}

int[,,] matrix = new int[n, n, n];
InputMatrix(matrix);
PrintMatrix(matrix);