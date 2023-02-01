// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPosNumArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
            if (arr[i] > 0) count++;
    return count;
}

Console.WriteLine("Введите число элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элемент массива с индексом №" + i + ": ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Заданный массив: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Число элементов в заданном массиве > 0 = " + CountPosNumArr(array));;