// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Проверка с использованием введенного числа через string.");
Console.Write("Ведите пятизначное (положительное целое) число: ");

string a = Console.ReadLine();
int l = a.Length; //эта переменная нужна при проверке, если убрать ограничение на 5 цифр

if (l<5||l>5) Console.WriteLine("Ошибка ввода");
else {
        int j = 0;
        for (int i = 0; i<=(l/2); i++)
            {
                if (a[i]<a[l-1-i]) {j=1; break;}
                else if (a[i]>a[l-1-i]) {j=1; break;}
            }
        if (j==1) Console.WriteLine("no");
        if (j==0) Console.WriteLine("yes");
     }



// Вариант без использования string (почти)):
Console.WriteLine("Проверка с использованием введенного числа через массив int.");
Console.Write("Ведите пятизначное (положительное целое) число: ");
string a1 = Console.ReadLine();
int l1 = a1.Length;
int b = int.Parse(a1);

if (b<10000||b>99999) Console.WriteLine("Ошибка ввода");
else {
       int[] N = new int[l1];;
       int b2;
       for (int j = 0; j<l1; j++) // раскидываем цифры числа b по массиву N
         {
            b2 = b % 10;
            N[l1-1-j] = b2;
            b = (b - b2)/10; //убираем последнюю цифру в числе b1
         }

       int x = 0;
       for (int k = 0; k<l1; k++) 
         {
            if (N[k]>N[l1-1-k]) {x = 1; break;}
            else if (N[k]<N[l1-1-k]) {x = 1; break;}
         }
        if (x==1) Console.WriteLine("no");
        if (x==0) Console.WriteLine("yes");

     }