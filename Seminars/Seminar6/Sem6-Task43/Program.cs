// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задаем параменты уравления типа y = a*x + b");
Console.WriteLine("Введите параметры первого уравления:");
Console.Write("a1 = ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите параметры второго уравления:");
Console.Write("a2 = ");
double a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Точка пересечения уравнений: ");
if (b1>=0) Console.WriteLine("Y = " + a1 + "x + " + b1);
else {Console.WriteLine("Y = " + a1 + "x " + b1);}

if (b2>=0) Console.WriteLine("Y = " + a2 + "x + " + b2);
else {Console.WriteLine("Y = " + a2 + "x " + b2);}

Console.WriteLine();
double x = 0;
if (((a1-a2)>0)||((a1-a2)<0)) 
    {
        x = ((b2-b1)/(a1-a2));
        Console.WriteLine("X = " + Math.Round(x,4));
        Console.WriteLine("Y = " + Math.Round((a1*x+b1),4));
    }
else Console.WriteLine("Прямые параллельны.");

