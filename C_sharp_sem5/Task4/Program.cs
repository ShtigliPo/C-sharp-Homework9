// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(0, 1000);
        index++;
    }
    return array;
}

void PrintArray(int[] a) // вывод массива на консоль
{
    int count = a.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write($"{a[i]} ");
        i++;
    }
    Console.WriteLine();
}

int FindColArray(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] <= 99 && a[i] >= 10)
        {
            count++;
        }
    }
    return count;
}

int[] array = RandomArray(123);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(FindColArray(array));
