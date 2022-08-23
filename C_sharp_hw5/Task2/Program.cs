// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int SumOddPositionsNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = CreateArray(10, -10, 10);
PrintArray(array);
int sum = SumOddPositionsNumbers(array);
System.Console.WriteLine($"Сумма чисел, нечетных позиций маcсива, равна {SumOddPositionsNumbers(array)}");
