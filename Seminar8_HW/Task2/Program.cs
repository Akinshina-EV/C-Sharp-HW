// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int i, int j, int min, int max)
{
    int[,] matrix = new int[i,j];
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min,max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int row = 4;
int column = 5;
int min = 1;
int max = 10;
int[,] matrix = GetMatrix(row, column, min, max);
PrintMatrix(matrix);
Console.WriteLine();

int[] rowMatrix = new int[column];
int[] sumRow = new int[row];
int minSumRow = max * column;
int numberMinSumRow = 0;
for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            rowMatrix[j] = matrix[i,j];
            sumRow[i] += rowMatrix[j]; 
        }
        if(sumRow[i] < minSumRow)
            {
            minSumRow = sumRow[i];
            numberMinSumRow = i+1;
            }
    }   

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberMinSumRow} строка");