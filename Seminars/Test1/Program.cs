// Пользователь вводит массив из произвольного (заданного пользователем) числа строк произвольной длинны.
// Написать программу, которая из введенного массива строк выбирает строки, 
// длинна которых менее или равна длины строки исходного массива с индексом "3"
// и формирует из них отдельный массив строк

Console.WriteLine("Введите массив строк.");
Console.Write("Задайте число строк (элементов) массива: n = ");
int k1 = Convert.ToInt32(Console.ReadLine());
string[] arr1 = new string[k1];
Console.WriteLine("Введите " + k1 + " строк массива через пробел:");
arr1 = Console.ReadLine().Split(' ');

int k2 = 0; //длинна результирующего массива
for (int i = 0; i < k1; i++)
    {
        if (arr1[i].Length <= arr1[3].Length)
        k2 = k2 + 1;        
    }

string[] arr2 = new string[k2];
int j = 0;
for (int i = 0; i < k1; i++)
    {
        if (arr1[i].Length <= arr1[3].Length)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }

Console.WriteLine();
Console.WriteLine("Полученный массив:");
for (int i = 0; i < k2; i++)
    Console.Write(arr2[i] + "; ");
    Console.WriteLine("\b\b.");