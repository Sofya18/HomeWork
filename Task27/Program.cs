// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n, sum = 0;
while (m > 0)
{
    sum += m % 10;
    m /= 10;
}
Console.WriteLine($"Сумма цифр в числе {n} = {sum}.");

