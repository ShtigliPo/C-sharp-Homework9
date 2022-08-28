// Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

Random rand = new Random();

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[3, 3];

FillMatrix(matrix);
PrintArray(matrix);
System.Console.WriteLine("Input a number: ");
int element = int.Parse(Console.ReadLine() ?? "0");
findElem(matrix, element);


void findElem (int[,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(element == matrix[i, j])
            {
              System.Console.WriteLine($"Entered number is on the [{i},{j}] position");
              return;
            }
        }

    }
    System.Console.WriteLine($"There is no such element in this matrix");

    
}
