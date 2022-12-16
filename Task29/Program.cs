// Напишите программу, которая спрашивает у пользователя кол-во элементов массива, затем сами элементы. Программ должна вывести массив на экран.

void PrintArray(int[] arr)
{   
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}
Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i+1}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.Write("Итоговый массив: ");
PrintArray(array);

