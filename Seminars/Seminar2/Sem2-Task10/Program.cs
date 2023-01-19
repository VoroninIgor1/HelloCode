// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3х-значное целое число");
int a = int.Parse(Console.ReadLine());
if (a<100 || a>999) Console.WriteLine("Некорректный ввод");
else {
    int b = a % 10; 
    a = (a - b)/10;
    b = Convert.ToInt32(Math.Sqrt((a % 10)*(a % 10))); 
    Console.WriteLine(b);}