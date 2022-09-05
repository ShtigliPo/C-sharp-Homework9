// Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowEvenNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.Write($"{m}\t");
    }
    ShowEvenNaturalNumbers(m + 1, n);

}

int m = Prompt("Введите значение M ");
int n = Prompt("Введите значение N ");
ShowEvenNaturalNumbers(m, n);
System.Console.WriteLine();
