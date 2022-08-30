// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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

void PrintArray(int[,] matrix) 
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

void AvgColumn(int[,]matrix)
{
    double result = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result += matrix[j, i];
        }
        System.Console.WriteLine($"Среднее арифм. элементов в {i+1} столбце = {Math.Round(result/matrix.GetLength(0), 1)}");
        result = 0;
    }
}

int line = Prompt("Введите количество строк массива ");
int column = Prompt("Введите количество столбцов массива ");
int[,] matrix = FillArray(line, column); 
PrintArray(matrix);
AvgColumn(matrix);
