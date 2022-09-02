// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] FillArray(int line, int column)
{
    int[,] matrix = new int[line, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (int)(new Random().Next(0, 10));
        }
    }
    return matrix;
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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            product[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
                product[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
    return product;
}

void Main()
{
    int a = Prompt("Введите число строк матрицы A ");
    int b = Prompt("Введите число столбцов Матрицы A ");
    int c = Prompt("Введите число строк матрицы B ");
    int d = Prompt("Введите число столбцов Матрицы B ");
    if (!(a > 0 && b > 0 && c > 0 && d > 0))
    {
        System.Console.WriteLine("Невозможно решить задачу с такими парметрами");
        return;
    }
    int[,] array1 = FillArray(a, b);
    int[,] array2 = FillArray(c, d);
    PrintMatrix(array1);
    System.Console.WriteLine();
    PrintMatrix(array2);
    System.Console.WriteLine();
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        System.Console.WriteLine("Матрицы не совместимы");
        return;
    }
    int[,] result = MatrixMultiplication(array1, array2);
    PrintMatrix(result);
}

Main();