// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

double[] CreateArray(int length, int min, int max)
{
    double[] answer = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.NextDouble() * 100;
    }
    return answer;
}

void PrintArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]:f2}\t");
    }
    System.Console.WriteLine();
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double DiffMinMax(double[] array)
{
    return FindMax(array) - FindMin(array);
}

double[] array = CreateArray(10, -99, 99);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива, равна {DiffMinMax(array):f2}");