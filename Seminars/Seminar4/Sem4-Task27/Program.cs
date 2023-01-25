// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Ведите любое целое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {a} = {SumOfNum(a)}");;

int SumOfNum(int num)   //функция расчета суммы цифр введенного числа
{
   int num1 = Math.Abs(num);
   int sum = 0; 

   if ((num==0)) return 0; 
   else {
         for (int j = 1; num1>0; j++) 
          {
            int b2 = num1 % 10;
            sum = sum + b2;
            num1 = (num1 - b2)/10;
          }
         if (num>0) return sum;
         else return -sum;;
        }  
   }


