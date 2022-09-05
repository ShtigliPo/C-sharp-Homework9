// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool PrimeNumber(int num, int divider)
{
    if (divider == 1)
    {
        return true;
    }
    return PrimeNumber(num, divider - 1 ) && (num % divider > 0);
}

int n = Prompt("Введите число ");
int divider = n - 1;
bool result = PrimeNumber(n, divider);
System.Console.WriteLine(result);