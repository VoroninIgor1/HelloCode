// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число от 1 до 7");
int a = int.Parse(Console.ReadLine());
if (a<8 && a>0) 
    {   if (a>5) Console.WriteLine("Да");
        else Console.WriteLine("Нет");
    }
else Console.WriteLine("Некорректный ввод");