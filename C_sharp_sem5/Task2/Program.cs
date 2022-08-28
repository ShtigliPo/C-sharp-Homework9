// Напишите программу замены элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(-9, 9);
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

int[] Perevorot(int[] a)
{
    int count = a.Length;
    int i = 0;
    for (i = 0; i < count; i++)
    {
        a[i] = -a[i];
    }
    return a;
}

int[] array1 = RandomArray(8);
PrintArray(array1);
PrintArray(Perevorot(array1));