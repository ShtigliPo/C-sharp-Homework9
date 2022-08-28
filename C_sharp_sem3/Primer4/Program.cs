// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5-> 1, 4, 9, 16, 25.
// 2-> 1,4

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void SetN(int num)
{
    int i = 1;
    while (i <= num)
    {
        System.Console.Write(i * i + " ");
        i++;
    }
}
SetN(Prompt("Введите число : "));
