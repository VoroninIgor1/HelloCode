// на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число.");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до указанного числа:");
int index = 1;
if (n>0) {while (index<=n) {
                            if (index %2 == 0) Console.Write(index + "; ");
                            index++;
                           }
         }
else if (n<0) {while (index>=n) {
                                if (index %2 == 0) Console.Write(index + "; ");
                                index--;
                               }
              }
else if (n==0) Console.WriteLine("0");

Console.Write("\b\b.");