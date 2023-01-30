// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] MakeArr(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,1000); 
    return array;
}

int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2==0) count++; 
    return count;
}

Console.WriteLine("введите длину массива");
int a = int.Parse(Console.ReadLine());
int[] arr = MakeArr(a);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine("Число четных элементов в массиве = " + CountEvenNum(arr));