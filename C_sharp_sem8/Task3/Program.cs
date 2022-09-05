// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9


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
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray2(int[,] array)
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

void PrintArray1(int[] a)
{
    int count = a.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write($"{i} - {a[i]}\t");
        i++;
    }
}


int[] FrequencyDictionary(int[,] array)
{
    int[] answer = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                answer[array[i, j]]++;
            }
        }
    }
    return answer;
}

int[,] array = FillArray(Prompt("Введите число строк "), Prompt("Введите число столбцов "));
PrintArray2(array);
System.Console.WriteLine();
int[] freqarray = FrequencyDictionary(array);
PrintArray1(freqarray);