// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Ведите целое число ");
int num = int.Parse(Console.ReadLine());
if (num >= 1)
    {
        for (int i = 1; i <= num; i++)
        {
          Console.Write(Math.Pow(i,3) + ", ");
        }
    Console.WriteLine("\b\b ");
    }
else { //если введенное число меньше единицы (в т.ч. отрицательное), 
       //то диапазон от 1 до N включает кубы 1, 0 и далее до N
        for (int i = 1; i >= num; i--)
        {
          Console.Write(Math.Pow(i,3) + ", ");
        }
        Console.WriteLine("\b\b ");
     }