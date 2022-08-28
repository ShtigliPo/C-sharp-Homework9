// Фиббаначи без массива
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

void CountFibbanachi(int numberFibb)
{
    int f1 = 0;
    int f2 = 1;
    int f;

    int i = 2;
    while (i < numberFibb)
    {
        f = f1 + f2;
        f1 = f2;
        f2 = f;
        System.Console.WriteLine(f);
        i++;
    }
}

CountFibbanachi(Prompt("Введите число: "));

