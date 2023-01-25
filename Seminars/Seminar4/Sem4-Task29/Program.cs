// Задача 29: Напишите программу, которая задаёт массив из заданного числа элементов 
// принимает значения элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Задайте число элементов массива: ");
int numarr = int.Parse(Console.ReadLine());
int[] Arr = new int[numarr];

for(int i=0;i<Arr.Length;i++) //заполнение массива
    {
        Console.Write($"Введите {i}й элемент массива: ");
        Arr[i] = int.Parse(Console.ReadLine());
    }
Console.Write("Заданный массив: ");
for (int i = 0; i < Arr.Length; i++) //вывод массива
    {
        Console.Write($"{Arr[i]}; ");
    }
Console.WriteLine("\b\b.");