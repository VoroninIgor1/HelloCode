// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7    -2  -0,2
// 1  -3,3   8  -9,9
// 8   7,8  -7,1  9

double[,] MakeDoubleArr()
{
    Console.WriteLine("Введите число строк массива - значение М: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов массива - значение N: ");
    int column = Convert.ToInt32(Console.ReadLine());
    double[,] arr = new double[line, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int a = new Random().Next(-100,101); //переменная для расширения значения элемента массива на отрицательные значения. Ноль здесь должен занимать не значимый %.
            arr[i, j] = Math.Round((a/10)*new Random().NextDouble() , 1);
        }
    }
    return arr;
}

void PrintDoubleArr(double[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],5}");
        }
        Console.WriteLine();
    }
}

double[,] arr = MakeDoubleArr();
PrintDoubleArr(arr);