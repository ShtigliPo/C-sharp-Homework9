// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

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

int[] ToBinary(int number)
{
    int[] array = new int[10];
    int i = array.Length - 1;
    while (number > 0)
    {
        int bit = number % 2;
        number = number / 2;
        array[i] = bit;
        i--;
    }
    return array;
}

int[] array = ToBinary(Prompt("Введите число: "));
PrintArray(array);


