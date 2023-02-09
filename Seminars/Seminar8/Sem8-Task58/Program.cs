// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MultiplicationTwoMatrix(int[,] arr1, int[,] arr2)
{
    // произведение матрицы arr1[a,b] на arr2[b,c] = mult[a,c]
    if (arr1.GetLength(1) != arr2.GetLength(0))
        Console.WriteLine("Операция умножения матриц не определена (число столбцов матрицы А не равно числу строк матрицы В).");
    else
    {
        int[,] mult = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                mult[i, j] = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                    mult[i, j] = mult[i, j] + arr1[i, k] * arr2[k, j];
            }
        }
        PrintArray(mult);
    }
}

int[,] CreateIntArray(int line, int col)
{
    int[,] array = new int[line, col];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1,10);
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

int[,] arr1 = CreateIntArray(5, 10);
PrintArray(arr1);
Console.WriteLine();
int[,] arr2 = CreateIntArray(10, 7);
PrintArray(arr2);
Console.WriteLine();
MultiplicationTwoMatrix(arr1, arr2);