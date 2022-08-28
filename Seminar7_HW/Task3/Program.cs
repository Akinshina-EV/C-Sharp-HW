// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] matrix = new double[3,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write("{0} ", matrix[i,j]);
    }
        Console.WriteLine();
}

double[] averageColumn = new double[matrix.GetLength(1)];

for (int j = 0; j < matrix.GetLength(0); j++)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        averageColumn[i] += Math.Round(matrix[j, i] / matrix.GetLength(0), 1);
    }
}

Console.WriteLine("Среднее арифметическое каждого столбца: ");
Console.WriteLine("{0}", string.Join("; ", averageColumn));
