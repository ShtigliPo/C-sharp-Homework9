// напечатать последовательность 1 2 2 3 3 3 4 4 4 4
// N = 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void printNumbers(int value)    //
{
    int count = 0;                                      //Cчетчик для подсчета колличества выведенных чисел
    int i = 0;                                            //Счетчик для группы одинаковых числе
    while (true)                                         //Внешний цикл групп
    {
        for (int j = 0; j < i; j++)                     //Внутриний цикл для вывода чисел в группе
        {
            System.Console.WriteLine($"{i} ");          //Вывод числа
            count++;                                    //Увеличения счетчика
            if (count == value)                           //Условия выхода
            {
                return;
            }


        }
        i++;                                            //Счетчик групп
    }
}
int number = Prompt("Введите число ");
printNumbers(number);