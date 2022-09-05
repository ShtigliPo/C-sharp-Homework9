// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalRow(int number)
{
    if (number <= 0)
    {
        return;
    }

    ShowNaturalRow(number - 1);
    System.Console.WriteLine(number);
}

int number = Prompt("Введите число > ");
ShowNaturalRow(number);