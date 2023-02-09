// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateIntArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(4, 6), random.Next(4, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(-5, 6);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
}

int[,] SortLineArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp;
        for (int k = 0; k < array.GetLength(1) - 1; k++)
            for (int l = k + 1; l < array.GetLength(1); l++)
                if (array[i, k] < array[i, l])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, l];
                    array[i, l] = temp;
                }
    }
    return array;
}

int[,] arr = CreateIntArray();
PrintArray(arr);
Console.WriteLine();
PrintArray(SortLineArray(arr));