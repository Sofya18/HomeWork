// Программа, принимающая на вход пятизначное число с проверкой того, является ли это числ

bool NumberInInterval(int a, int b, int c)
{
    if (a >= b && a <= c)
        return true;
    else 
    {
        Console.WriteLine($"Ошибка! Число должно находиться в интервале от {b} до {c}!");
        return false;
    }   
}

Console.Clear();
string m;
int n;
do
{
    Console.Write("Введите пятизначное число: ");
    m = Console.ReadLine();
    n = Convert.ToInt32(m);
} while (!NumberInInterval(n, 10000, 99999));

if ((n / 10000 == n % 10) && (n % 10000 / 1000 == n % 100 / 10))
    Console.WriteLine($"Число {n} - палиндром.");
else
    Console.WriteLine($"Число {n} - НЕ палиндром.");

