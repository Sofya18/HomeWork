// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M. Выполнить с помощью рекурсии.
string GetNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start < end) ? GetNumbers(start + 1, end) + $", {start}": 
                           GetNumbers(start, end + 1) + $", {end}";
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Числа: {GetNumbers(m, n)}");
