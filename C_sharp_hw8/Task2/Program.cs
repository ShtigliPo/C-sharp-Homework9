// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

int[] SumLine(int[,] matrix)
{
    int[] sum = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum[i] =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i,j];
        }
        
    }
    return sum;
}

void PrintArray(int[] newArray)
{
    for (int j = 0; j < newArray.Length; j++)
    {
        System.Console.Write($"{newArray[j]}\t");   
    }
}

int MinimumIndex(int[] array)
{
    int minNumber = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<minNumber)
        {
            minNumber = array[i];
            index = i;
        }
    }
    return index;
}

int line = Prompt("Введите количество строк массива ");
int column = Prompt("Введите количество столбцов массива ");
int[,] array = FillArray(line, column);
PrintMatrix(array);
System.Console.WriteLine();
int[] sum = SumLine(array);
PrintArray(sum);
System.Console.WriteLine();
System.Console.WriteLine($"Наименьшая сумма элементов в {MinimumIndex(sum)} строке ");
System.Console.WriteLine($"наименьшая сумма элементов для пользователя в {MinimumIndex(sum) + 1} строке ");