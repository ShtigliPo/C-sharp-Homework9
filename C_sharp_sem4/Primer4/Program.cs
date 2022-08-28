// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

int [] array = new int[8];
int i = 0;
while (i < array.Length)
{
    array[i] = new Random().Next(0, 2);
    i++;
}
int count = 0;
while (count < array.Length)
{
    System.Console.Write($"{array[count]}");
    count++;
}
Console.Write($"{array}");