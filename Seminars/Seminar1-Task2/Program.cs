// на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите 2 числа.");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
if (a>b) Console.WriteLine("max=" + a + "; min=" + b);
else if (a<b) Console.WriteLine("max=" + b + "; min=" + a);
else if (a==b) Console.WriteLine(a + "=" + b);