// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int Prompt(string message)

{
    	System.Console.Write(message);          // Вывести сообщение
    	string readValue = Console.ReadLine();  // Считавает с консоли строку
    	int result = int.Parse(readValue);      // Преобразует строку в целое число
    	return result;                          // Возвращает результат
}

int value1 = Prompt ("Введите первое число ");
int value2 = Prompt ("Введите второе число ");
int value3 = Prompt ("Введите третье число ");

int max = value1;
if (max < value2)
{
    max = value2;
}
if (max < value3)
{
    max = value3;
}
System.Console.WriteLine($"Число {max} самое большое");