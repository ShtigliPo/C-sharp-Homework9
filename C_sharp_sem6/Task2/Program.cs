// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

bool Triangle(int numOne, int numTwo, int numThree)
{
    if (numOne + numTwo > numThree && numThree + numTwo > numOne && numThree + numOne > numTwo)
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (Triangle(Prompt("Первая сторона: "), Prompt("Вторая сторона: "), Prompt("Третья сторона: ")))
{
    System.Console.WriteLine("Треугольник существует");
}
else
{
    System.Console.WriteLine("Треугольник не существует");
}