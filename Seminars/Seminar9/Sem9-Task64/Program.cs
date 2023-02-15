// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("-> ");
Console.WriteLine(PrintNatNumber(N, 1));

string PrintNatNumber(int start, int end)
{
    if (start >= end)
    {
        if (start == end) return Convert.ToString(start);
        return (start + ", " + PrintNatNumber(start - 1, end));
    }
    else //если введенное число <1, то ряд от N до 1 будет следующим:
    {
        if (start == end) return Convert.ToString(start);
        return (start + ", " + PrintNatNumber(start + 1, end));
    }
}