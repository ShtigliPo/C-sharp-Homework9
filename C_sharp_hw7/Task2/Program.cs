// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            matrix[i, j] = (int)(new Random().Next(-9, 10));
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

bool CheckIndexes(int[,] matrix, int line, int column)
{
    bool result = true;
    if (matrix.GetLength(0) <= line || matrix.GetLength(1) <= column)
    {
        result = false;
    }
    return result;
}

void FindElement(int[,] matrix, int line, int column) 
{
    if (CheckIndexes(matrix, line, column))  
    {
        System.Console.Write($"В этом индексе число {matrix[line, column]}");
    }
    else
    {
        System.Console.Write("Такого элемента нет");
    }
}

int line = Prompt("Введите количество строк массива ");
int column = Prompt("Введите количество столбцов массива ");
int[,] matrix = FillArray(line, column); 
PrintArray(matrix);
FindElement(matrix, Prompt("Введите индекс строки "), Prompt("Введите индекс столбца "));
System.Console.WriteLine();