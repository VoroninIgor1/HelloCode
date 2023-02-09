// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите число строк массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[x, y];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
}

int[,] FillArray2m(int[,] array)
{
    int s = 0; //значение ячейки в массиве
    int x = 0; //индекс строки
    int y = 0; //индекс столбца
    int countN; //число больших циклов (прямоугольников)
    int minXY;
    if (array.GetLength(0) < array.GetLength(1)) minXY = array.GetLength(0);
    else minXY = array.GetLength(1);
    if (minXY % 2 == 0) countN = minXY / 2;
    else countN = (minXY + 1) / 2;
    int num = (array.GetLength(0) * array.GetLength(1)); //число ячеек

        for (int n = 1; (n <= countN)&&(s <= num); n++)
        {
            int y1;
            x = n - 1;
            //направо            
            for (y1 = y; (y1 <= (array.GetLength(1) - n))&&(s < num); y1++)
            {
                arr[x, y1] = s + 1;
                s = arr[x, y1];
            }
            y = y1 - 1;
            x = x + 1;
            int x1;
            //вниз
            for (x1 = x; (x1 <= (array.GetLength(0) - 1 - n))&&(s < num); x1++)
            {
                arr[x1, y] = s + 1;
                s = arr[x1, y];
            }
            x = x1;
            int y2;
            //налево
            for (y2 = y; (y2 >= (n - 1))&&(s < num); y2--)
            {
                arr[x, y2] = s + 1;
                s = arr[x, y2];
            }
            y = y2 + 1;
            x = x - 1;
            int x2;
            //вверх
            for (x2 = x; (x2 >= n)&&(s < num); x2--)
            {
                arr[x2, y] = s + 1;
                s = arr[x2, y];
            }
            y = y + 1;
        }
    return array;
}

Console.WriteLine();
FillArray2m(arr);
PrintArray(arr);