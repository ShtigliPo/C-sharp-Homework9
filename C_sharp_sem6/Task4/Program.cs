// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 4}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("] -> ");
}

int[] CountFibbanachi(int numberFibb)
{
    int[] array = new int[numberFibb];
    array[0] = 0;
    array[1] = 1;
    int i = 2;
    while (i < numberFibb)
    {
        array[i] = array[i - 2] + array[i - 1];
        i++;
    }
    return array;
}

int[] array = CountFibbanachi(Prompt("Введите число: "));
PrintArray(array);
