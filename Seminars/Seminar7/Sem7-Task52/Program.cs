// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillIntArrayRandom(int[,] arr)
{
    for (int line = 0; line < arr.GetLength(0); line++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            arr[line, column] = new Random().Next(1, 11);
            Console.Write($"{arr[line, column],3}");
        }
        Console.WriteLine();
    }
}

void AverageLineArray(int[,] array)
{
    double[] averageLine = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i,j];
        averageLine[i] = Math.Round(Convert.ToDouble(sum)/array.GetLength(1),2); 
    }
    Console.WriteLine($"Среднее арифметическое строк: [{string.Join("; ", averageLine)}]");
}

void AverageColumnArray(int[,] array)
{
    double[] averageColumn = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum = sum + array[j,i];
        averageColumn[i] = Math.Round(Convert.ToDouble(sum)/array.GetLength(0),2); 
    }
    Console.WriteLine($"Среднее арифметическое столбцов: [{string.Join("; ", averageColumn)}]");
}

int[,] array = new int[5,7];
FillIntArrayRandom(array);
AverageLineArray(array);
AverageColumnArray(array);