// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CalculateAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0 && m > 0)
        {
            return CalculateAkkermanFunction(m - 1, 1);
        }
        else
        {
            return CalculateAkkermanFunction(m - 1, CalculateAkkermanFunction(m, n - 1));
        }
    }
}

int m = Prompt("Введите значение M ");
int n = Prompt("Введите значение N ");
System.Console.WriteLine($"A(m,n) = {CalculateAkkermanFunction(m, n)}");