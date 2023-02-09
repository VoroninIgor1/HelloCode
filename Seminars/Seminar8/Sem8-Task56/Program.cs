// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] CreateIntArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(4, 6), random.Next(3, 5)];
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

int[] SumLineArray(int[,] array) //в текущей задаче не используется (этот блок кода использован в следующей функции)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i] = sum[i] + array[i, j];
    return sum;
}

int NumMinSumLineArray(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i] = sum[i] + array[i, j];
    int indexminsum = 0;
    int minsum = 0;
    for (int j = 0; j < sum.Length; j++)
        if (sum[j] < minsum) 
        {
            minsum = sum[j];
            indexminsum = j;
        }
    return indexminsum;
}

int[,] arr = CreateIntArray();
PrintArray(arr);
Console.WriteLine($"Индекс строки с минимальной суммой элементов: [{NumMinSumLineArray(arr)}]");