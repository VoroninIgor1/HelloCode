//на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("Введите число.");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
if ((a % 2) == 0) Console.WriteLine("число " + a + " - четное");
else Console.WriteLine("число " + a + " - нечетное");