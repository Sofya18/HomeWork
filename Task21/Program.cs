// Программа, принимающая на вход координаты двух точек, после чего находит расстояние между ними в 3D пространстве

Console.Clear();

double a1, b1, c1, a2, b2, c2;

Console.Write("Введите координату A 1-й точки: ");
a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату B 1-й точки: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату C 1-й точки: ");
c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату A 2-й точки: ");
a2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату B 2-й точки: ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату C 2-й точки: ");
c2 = Convert.ToDouble(Console.ReadLine());

double d = Math.Round(Math.Sqrt((a2 - a1) * (a2 - a1) +
                                (b2 - b1) * (b2 - b1) +
                                (c2 - c1) * (c2 - c1)), 2);

Console.WriteLine($"Расстояние между точками: {d}");
