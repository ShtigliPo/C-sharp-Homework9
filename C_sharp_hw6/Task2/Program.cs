// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void InputNumbers(double k1, double b1, double k2, double b2)
{
    if (b1 == b2 && k1 == k2)
    {
        System.Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны");
    }
    else
    {
        (var x, var y) = IntersectionPoint(k1, b1, k2, b2);
        Console.WriteLine($"Координаты точки пересечения ({(x):f2}; {(y):f2})");
    }
}

(double, double) IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

int k1 = Prompt("Введите значение k1 ");
int b1 = Prompt("Введите значение b1 ");
int k2 = Prompt("Введите значение k2 ");
int b2 = Prompt("Введите значение b2 ");
InputNumbers(k1, b1, k2, b2);