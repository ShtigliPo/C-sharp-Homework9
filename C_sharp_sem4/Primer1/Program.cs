// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumSequence(int number)
{
    int answer = 0;
    for (int i = 0; i <= number; i++ )
{
    answer = answer + i
}
return answer;
}

int number = Prompt ("Введите число для суммы ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} составляет {SumSequence(number)}");