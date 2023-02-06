// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

void FillIntArrayRandom(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int colums = 0; colums < arr.GetLength(1); colums++)
        {
            arr[rows, colums] = new Random().Next(1, 11);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}");
        }
        Console.WriteLine();
    }
}

void FindNumArr(int[,] arr, int i, int j)
{
    if ((i < arr.GetLength(0)) && (j < arr.GetLength(1)))
        Console.Write($"Элемент массива с координатами [{i}; {j}]: {arr[i, j]}");
    else Console.WriteLine("Элемента с указанными координатами в массиве не найдено.");
}

int[,] arr = new int[4, 5];
FillIntArrayRandom(arr);
PrintArr(arr);

Console.WriteLine("Введите координаты элемента массива (через пробел) №строки, № столбца");
string[] index = new string[2];
index = Console.ReadLine().Split(' ');
FindNumArr(arr, Convert.ToInt32(index[0]), Convert.ToInt32(index[1]));