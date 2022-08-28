// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void InputNumbers(int number)
{
    if (number > 0)
    {
        int[] array = ArrayInput(number);
        ArrayPrint(array);
        System.Console.WriteLine($"Количество положительных чисел {CountPositiveNumber(array)}");
    }
    else
    {
        System.Console.WriteLine("Количество чисел не может быть нулевым или отрицательным");
    }
}

int[] ArrayInput(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < number)
    {
        Console.Write("Введите число ");
        array[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return array;
}
int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void ArrayPrint(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j]} ");
    }
}

int number = Prompt("Сколько чисел будете вводить? ");
InputNumbers(number);



