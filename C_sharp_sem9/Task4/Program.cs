// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    
    return a * Power(a, b - 1);
}

int a = Prompt("Введите a ");
int b = Prompt("Введите b ");
int power = Power(a,b);
System.Console.WriteLine(power);