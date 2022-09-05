// Задайте значения M и N. Напишите программу, 
// которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalRow(int min, int max)
{
    if (min > max)
    {
        return;
    }

    ShowNaturalRow(min, max - 1);

    System.Console.WriteLine(max);
}

int min = Prompt("Введите минимум ");
int max = Prompt("Введите максимум ");
ShowNaturalRow(min,max);