// Напишите программу, которая будет принимать на вход пять чисел 
// и выводить сумму и среднее арифметическое этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int[] inputarray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i} число ");
    }
    return array;
}
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}
int[] array = inputarray(5);
int sum = Sum(array);
double avg = sum / ((double)array.Length);
System.Console.WriteLine($"Сумма чисел равна {sum}, среднее арифметическое равно {avg}");
