// Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] FillArray(int line, int column) 
{
    int[,] matrix = new int[line, column];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = (int)(new Random().Next(0, 10));
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SumLineMax(int[,] matrix) 
{
    int max = 0;
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        max = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] > max)
            {
                max = matrix[i, j];
            }
        }
        result += max;
    }
    return result;
}

int SumColumnMin(int[,] matrix) 
{
    int min = 0;
    int result = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min = matrix[0, i];
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if(matrix[j, i] < min)
            {
                min = matrix[j, i];
            }
        }
        result += min;
    }
    return result;
}

int line = Prompt("Введите количество строк массива ");
int column = Prompt("Введите количество столбцов массива ");
int[,] matrix = FillArray(line, column); 
PrintArray(matrix);
System.Console.WriteLine($"Разность сумм равна {SumLineMax(matrix) - SumColumnMin(matrix)}");
System.Console.WriteLine(SumLineMax(matrix) - SumColumnMin(matrix));
