//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите элементы массива: ");

double[] array = Console.ReadLine().Split(" ").Select(x => Convert.ToDouble(x)).ToArray();
Console.WriteLine($"Массив: {string.Join(" ", array)}");
int count = 0;

foreach (double element in array)
{
    if (element > 0.0) count++;
}

Console.WriteLine($"Количество чисел больше 0 в массиве = {count}");