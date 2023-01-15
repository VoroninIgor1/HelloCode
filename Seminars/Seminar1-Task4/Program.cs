// принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите 3 числа.");
Console.Write("a=");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b=");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c=");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

if (a>b) {
          if (a>c) Console.WriteLine("max=a=" + a);
          else if (a==c) Console.WriteLine("max=a=c=" + a);
         }   

if (b>a) {
          if (b>c) Console.WriteLine("max=b=" + b);
          else if (b==c) Console.WriteLine("max=b=c=" + b);
         }   

if (c>b) {if (c>a) Console.WriteLine("max=" + c);}
    else if (b==a) Console.WriteLine("max=a=b=" + a);
 
if (c==a) {if (c==b) Console.WriteLine("все 3 числа одинаковые, max=a=b=c=" + a);}