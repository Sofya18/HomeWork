﻿// Программа, принимающая на вход число N и выводит таблицу кубов чисел от 1 до N

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    Console.WriteLine($"{i} - {i * i * i}");







