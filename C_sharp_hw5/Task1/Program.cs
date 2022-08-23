// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max);
    }
    return answer;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int NumberEvenNumbers(int[] array)
{
    int evenNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNumber ++;
        }
    }
    return evenNumber;
}

int[] array = CreateArray(10, 99, 1000);
PrintArray(array);
int evenNumber = NumberEvenNumbers(array);
System.Console.WriteLine($"Количество четных чисел в массиве {NumberEvenNumbers(array)}");