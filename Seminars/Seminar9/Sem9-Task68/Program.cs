// https://yandex.ru/images/search?pos=4&img_url=http%3A%2F%2Ffuzeservers.ru%2Fwp-content%2Fuploads%2Fb%2F7%2F7%2Fb779d8c4ff34605dca5ecc08ac8da49c.jpeg&text=%D1%84%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F%20%D0%B0%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0&lr=22&rpt=simage&source=serp
// https://yandex.ru/images/search?pos=4&img_url=http%3A%2F%2Ffuzeservers.ru%2Fwp-content%2Fuploads%2Fb%2F7%2F7%2Fb779d8c4ff34605dca5ecc08ac8da49c.jpeg&text=%D1%84%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F%20%D0%B0%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0&lr=22&rpt=simage&source=serp
// https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два неотрицательных числа.");
Console.WriteLine("Число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Значение функции Аккермана = " + Akkerman(m, n));

ulong Akkerman(int m, int n)
{
    if (m == 0) return (Convert.ToUInt64(n) + 1);
    else if ((n == 0) && (m > 0)) return Akkerman(m - 1, 1);
    //else при ((n>0)&&(m>0))  
        return Akkerman(m - 1, Convert.ToInt32(Akkerman(m, n - 1)));
}