﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размер двумерного массива:");

Console.WriteLine("количество строк: ");
int m = Int32.Parse(Console.ReadLine());

Console.WriteLine("количество столбцов: ");
int n = Int32.Parse(Console.ReadLine());

double[,] matrix = new double[m,n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round(Convert.ToDouble(new Random().Next(-100, 100) / 10.0), 1);
        Console.Write("{0} ", matrix[i,j]);
    }
    Console.WriteLine();
}
