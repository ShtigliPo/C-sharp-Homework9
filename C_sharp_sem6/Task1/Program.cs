// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

double[] ArrayFill(int size)
{
    int i = 0;
    double[] array = new double[size];

    while (i < size)
    {
        if (new Random().Next(0, 2) == 0) // или целое или дробное

        {
            array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 100), 1);
        }
        else
        {
            array[i] = new Random().Next(0, 100);
        }

        i++;
    }
    return array;
}


void PrintArray(double[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(" {0, 4}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("] -> ");
}
double[] ReversArray(double[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        double tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

double [] array = ArrayFill (6);
PrintArray(array);
PrintArray(ReversArray(array));