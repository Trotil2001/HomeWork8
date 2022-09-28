/*
Дополнительная задача
Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/

void Triangle(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int space = n; space > i; space--)
            Console.Write(" ");

        int num = 1;
        for (int j = 1; j <= i; j++)
        {
            Console.Write(num + " ");
            num = num * (i - j) / j;
        }
        Console.WriteLine("");
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Triangle(n);


