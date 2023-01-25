// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Ведите целое число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ведите целое положительное число B: ");
int b = int.Parse(Console.ReadLine());
int a1 = a;
for (int i=2;i<=b;i++) a1=a1*a;
Console.Write($"Число {a} в степени {b} = {a1}");