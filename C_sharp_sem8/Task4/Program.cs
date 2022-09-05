// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
{
    int[,] matrix = new int[numLine, numColumns];   // Создание нового массива
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
        {
            matrix[i, j] = new Random().Next(-10, 10);      // Формула для заполнения массива
        }
    }
    return matrix;      // Возвращаем результат
}

void PrintArray(int[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
        {
            Console.Write($"{matrix[i, j]}\t");     // Вывод значений очередной строки 
        }
        Console.WriteLine();    // Переход на следующую строку
    }
}

int[] MinElementIndex(int[,] array)
{
    int[] answer = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[answer[0], answer[1]])
            {
                answer[0] = i;
                answer[1] = j;
            }
        }
    }
    return answer;
}

int[,] DeleteMin(int[,] array)
{
    int[] indexes = MinElementIndex(array);
    int[,] Result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int l = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != indexes[0] && j != indexes[1])
            {
                Result[k, l] = array[i, j];
                l++;
            }
        }
        if (i != indexes[0]) k++;
    }
    return Result;
}

int[,] array = FillArray(Prompt("Введите число строк > "), Prompt("Введите число столбцов > "));
PrintArray(array);
System.Console.WriteLine();
int[,] newarray = DeleteMin(array);
PrintArray(newarray);
