// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
        for (int col = 0; col < matrix.GetLength(1); col++)
            matrix[row, col] = new Random().Next(-10, 11);
}

void OutputMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
            Console.Write($"{matrix[row, col]}\t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Исходная матрица:");
OutputMatrix(matrix);

double[] means = new double[size[1]];

for (int col = 0; col < matrix.GetLength(1); col++)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        means[col] += matrix[row, col];
    }
    means[col] /= (double)matrix.GetLength(0);
}

Console.WriteLine("Среднее арифметическое каждого столбца: ");
Console.WriteLine(string.Join("   ",means));