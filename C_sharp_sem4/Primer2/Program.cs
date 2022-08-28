// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int number = Prompt("Введите число ");
int count = 0;
while (number > 0)
{
    number = number / 10;
    count++;
}
System.Console.WriteLine($"Количество цифр в числе {count}");