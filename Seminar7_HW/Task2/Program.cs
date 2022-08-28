// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] matrix = new double[4,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
        Console.Write("{0} ", matrix[i,j]);
    }
        Console.WriteLine();
}

Console.WriteLine("Введите позиции элемента в двумерном массиве, например: 1,1: ");
int[] position = Console.ReadLine().Split(',').Select(Int32.Parse).ToArray();  
if(position[0] > matrix.GetLength(0) - 1 || position[1] > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента в массиве нет.");
}
else
{
    Console.WriteLine(matrix[position[0], position[1]]);
}
