// Задача 2: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void FindElement(int[,] array, int row, int column)
{
    if (row <= 0 || column <= 0)
    {
        Console.WriteLine($"В массиве нет позиции [{row},{column}]");
        return;
    }
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        Console.WriteLine($"На позиции [{row},{column}] расположен элемент со значением {array[row - 1, column - 1]}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}

int[,] array = FillArray(4, 4);
PrintArray(array);
int row = Promt("Введите позицию элемента в строке => ");
int column = Promt("Введите позицию элемента в колонке => ");
FindElement(array, row, column);