// Задача 38: Задайте массив целых чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] MakeArr(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,100); 
    return array;
}

int DifMaxMin(int[] array)
{
    int dif = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i]<min) min = array[i]; 
            if (array[i]>max) max = array[i]; 
        }
    dif = max - min;    
    return dif;
}

Console.WriteLine("введите длину массива");
int a = int.Parse(Console.ReadLine());
int[] arr = MakeArr(a);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + DifMaxMin(arr));