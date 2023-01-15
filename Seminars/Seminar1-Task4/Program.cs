// принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите 3 числа.");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
if (a>b&&a>c) Console.WriteLine("max=" + a);
if (b>a&&b>c) Console.WriteLine("max=" + b);      
if (c>a&&c>b) Console.WriteLine("max=" + c);