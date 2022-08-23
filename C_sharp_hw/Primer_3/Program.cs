// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)

{
    	System.Console.Write(message);          // Вывести сообщение
    	string readValue = Console.ReadLine();  // Считавает с консоли строку
    	int result = int.Parse(readValue);      // Преобразует строку в целое число
    	return result;                          // Возвращает результат
}

int value = Prompt("Введите число ");
int a = value % 2;
if (a == 0)
{
    System.Console.WriteLine($"Число {value} четное");
}
else
{
    System.Console.WriteLine($"Число {value} нечетное");
}