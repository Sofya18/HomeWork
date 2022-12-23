// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите данные (k, b) первой прямой: ");
double[] line1 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
Console.Write("Введите данные (k, b) второй прямой: ");
double[] line2 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();

double x, y;
if (Math.Abs(line1[0] - line2[0]) > 1e-6)
{
    x = (line2[1] - line1[1]) / (line1[0] - line2[0]);
    y = line1[0] * x + line1[1];
    Console.WriteLine($"Точка перечения двух прямых ({x}, {y}).");
}
else 
{
    Console.WriteLine("Прямые параллельны.");
}