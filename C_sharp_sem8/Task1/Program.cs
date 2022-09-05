// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int line, int column)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeRowColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }

    return array;
}


int [,] array = FillArray(5,5);
PrintArray(array);
System.Console.WriteLine();
int [,] newarray = ChangeRowColumn(array);
PrintArray(newarray);