// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

void PrintArray(int[,] array)
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

int[,] TransporationMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}

int[,] array = FillArray(Prompt("Введите число строк "), Prompt("Введите число столбцов "));
if (array.GetLength(0) != array.GetLength(1))
{
    System.Console.WriteLine("Число строк не равно числу колонн");
    return;
}
PrintArray(array);
System.Console.WriteLine();
int[,] newarray = TransporationMatrix(array);
PrintArray(newarray);