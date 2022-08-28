// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

const int minus = -1;
const int plus = 1;

int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max+1);
    }
    return answer;
}


void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int SumSignedElements(int[] array, int sign = plus)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * sign) > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

(int, int) SumPlusMinusElements(int[] array)
{
    int sumPlus = 0;
    int sumMinus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPlus += array[i];
        }
        if(array[i] < 0){
            sumMinus += array[i];
        }
    }
    return (sumMinus, sumPlus);
}


int[] array =  CreateArray(12, -9, 9);
PrintArray(array);
int sumPositive = SumSignedElements(array, plus);
int sumNegative = SumSignedElements(array, minus);
System.Console.WriteLine($"Сумма отрицательный {sumNegative}, а положительный {sumPositive}");
(int sumMinus, int sumPlus) = SumPlusMinusElements(array);
System.Console.WriteLine($"Сумма отрицательный {sumMinus}, а положительный {sumPlus}");
