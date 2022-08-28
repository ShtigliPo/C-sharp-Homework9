// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)

{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}

int printXY(float x, float y)
{
    System.Console.Write($"X={x}, Y={y} ");
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Плоскость 1");
        return 1;
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Плоскость 2");
        return 2;
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Плоскость 3");
        return 3;
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Плоскоть 4");
        return 4;
    }
    else
    {
        Console.WriteLine("Ошибка, координаты на оси!");
        return -1;
    }
}

void printSetXY(int num)
{
    if (num == 1) { System.Console.WriteLine("X > 0, Y > 0"); }
    if (num == 2) { System.Console.WriteLine("X < 0, Y > 0"); }
    if (num == 3) { System.Console.WriteLine("X < 0, Y < 0"); }
    if (num == 4) { System.Console.WriteLine("X > 0, Y < 0"); }
}
start:
int result = printXY(Prompt("Введите X : "), Prompt("Введите Y : "));
if (result < 0) { goto start; }

printSetXY(result);