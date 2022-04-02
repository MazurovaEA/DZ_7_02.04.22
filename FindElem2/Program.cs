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

int[] Promt(string message)
{
    Console.Write(message);
    string[] arr1 = Console.ReadLine().Split(new Char[] { ' ', ',' });
    int[] arr2 = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        arr2[i] = int.Parse(arr1[i]);
    }
    
    return arr2;
}

void FindElement(int[,] array, int[] pos)
{
    if (pos[0] <= 0 || pos[1] <= 0)
    {
        Console.WriteLine($"В массиве нет позиции [{pos[0]},{pos[1]}]");
        return;
    }
    if (pos[0] <= array.GetLength(0) && pos[1] <= array.GetLength(1))
    {
        Console.WriteLine($"На позиции [{pos[0]},{pos[1]}] расположен элемент со значением {array[pos[0] - 1, pos[1] - 1]}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}

int[,] array = FillArray(4, 4);
PrintArray(array);
int[] pos = Promt("Введите позицию элемента  => ");
FindElement(array, pos);