// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumOfNaturalNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма элементов -> {sum}");
        return;
    }
    sum = sum + (m++);
    SumOfNaturalNumbers(m, n, sum);

}

int m = Prompt("Введите значение M ");
int n = Prompt("Введите значение N ");
if (m > n)
{
    Console.WriteLine($"Число M не должно быть больше числа N");
}
else
{
    int sum = 0;
    SumOfNaturalNumbers(m, n, sum);
}
System.Console.WriteLine();
