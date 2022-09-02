// Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SpiralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int k = 1;
    int t = 0;
    int i, j = 0;
    int n1 = n;
    int m1 = m;

    while (k <= n1 * m1)
    {
        for (i = t; i < n; i++)
            array[j, i] = k++;
        j = n - 1;
        for (i = t + 1; i < m; i++)
            array[i, j] = k++;
        j = m - 1;
        for (i = n - 2; i >= t; i--)
            array[j, i] = k++;
        j = t;
        for (i = m - 2; i > t; i--)
            array[i, j] = k++;
        n--;
        m--;
        t++;
        j = t;
    }
    return array;
}

void Main()
{
    int m = Prompt("Введите количество строк ");
    int n = Prompt("Введите количество столбцов ");
    if (m < 1 || n < 1)
    {
        System.Console.WriteLine("Значение задано неверно ");
        return;
    }
    int[,] array = SpiralArray(m, n);
    PrintMatrix(array);
}

Main();
