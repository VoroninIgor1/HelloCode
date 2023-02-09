// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateIntArray3m(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    // Формирование 3х-мерного массива не повторяющимися 2х-значными числами (max размерность x*y*z<=90)
    if ((x * y * z) > 90)
    {
        Console.WriteLine("Размерность массива больше предела для заполнения уникальными 2х-значными числами!");
        int[,,] arr = new int[1, 1, 1];
        return arr;
    }
    else
    {
        int count = 10;
        for (int k = 0; k < array.GetLength(2); k++)
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j, k] = count;
                    count++;
                }
    }
    return array;
}

void PrintArray3m(int[,,] array)
{
    Console.WriteLine("Печать 3х-мерного массива по слоям оси Z:");
    for (int z = 0; z < array.GetLength(2); z++)
    {
        Console.WriteLine("Слой Z №" + z + ":");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, z],4}");
            Console.WriteLine();
        }
    }
}

void PrintNumArray3m(int[,,] array)
{
    Console.WriteLine("Печать 3х-мерного массива по элементам с индексами:");
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j, z],4}[{i}, {j}, {z}]");
            Console.WriteLine();
        }
    }
}

int[,,] arr = CreateIntArray3m(4, 4, 5);
PrintArray3m(arr);
Console.WriteLine();
PrintNumArray3m(arr);