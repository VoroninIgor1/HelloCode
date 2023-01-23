// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты X для точки А: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для точки А: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Z для точки А: ");
int az = int.Parse(Console.ReadLine());

Console.Write("Введите координаты X для точки B: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для точки B: ");
int by = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Z для точки B: ");
int bz = int.Parse(Console.ReadLine());

int x = ax - bx;
int y = ay - by;
int z = az - bz;

double d = Math.Round(
                       Math.Sqrt(
                                 Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2)
                                 )
                     ,2
                     );

Console.WriteLine("Расстояние между точками A и B = " + d);