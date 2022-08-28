// Дан массив. Заполнить его случайными числами. 

int[] arrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(0, 101);
        i++;
    }
    return array;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
}
int Max(int[] array)
{
    int maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum) { maxNum = array[i]; }
    }
    return maxNum;
}
double Mid(int[] array)
{
    double sumArray = 0;
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sumArray += array[i];
    }
    result = ((double)sumArray) / array.Length;
    return result;
}
int[] result = arrayFill(5);
printArray(result);
System.Console.Write($"Max={Max(result)} ");
System.Console.Write($"Mid={Mid(result)} ");