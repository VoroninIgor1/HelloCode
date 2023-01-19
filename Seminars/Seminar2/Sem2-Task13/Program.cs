﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
int a = int.Parse(Console.ReadLine());
if (a<100 && a>-100) Console.WriteLine("Третьей цифры нет");
else {
        int b;
        if (a>999)
            {
            while (a>999)       //оставляем в числе a только первые 3 цифры
              { b = a % 10; 
                a = (a - b)/10; //убираем последнюю цифру в числе a                
              }
            }
        
        if (a<-999)
            {
            while (a<-999)       
              { b = a % 10; 
                a = (a - b)/10;                            
              }
            }

        b = Convert.ToInt32(Math.Sqrt((a % 10)*(a % 10))); //берем по модулю 3ю цифру в числе а 
        Console.WriteLine(b);
     }