// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] MakeArr(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99,100); 
    return array;
}

int SumNotEvenInd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i%2==1) sum=sum+array[i]; 
    return sum;
}

Console.WriteLine("введите длину массива");
int a = int.Parse(Console.ReadLine());
int[] arr = MakeArr(a);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine("Сумма эл-ов массива с нечет.индексами = " + SumNotEvenInd(arr));