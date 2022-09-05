// Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return SumDigit(number / 10) + number % 10;

}

int number = Prompt("Введите число >");
int sum = SumDigit(number);
System.Console.WriteLine(sum);