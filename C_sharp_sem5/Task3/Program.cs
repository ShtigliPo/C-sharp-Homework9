// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

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

bool FindElement(int[] a, int num)
{
    int count = a.Length;
    int i = 0;
    int find;
    while (i < count)
    {
        if (a[i] == num) return true;
        i++;
    }
    return false;
}

int[] array = RandomArray(10);
PrintArray(array);
int num = number("Введите число для поиска ");
if (FindElement(array, num))
{
    Console.WriteLine($"Элемент {num} присутствует в массиве");
}
else
{
    Console.WriteLine($"Элемент {num} не присутствует в массиве");
}