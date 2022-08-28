// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int number = Prompt("Введите число ");
int mult = 1;
for(int i = 1; i <= number; i++)
{
    mult = mult * i;
}
System.Console.WriteLine($"Произведение чисел от 1 до {number} -> {mult}");