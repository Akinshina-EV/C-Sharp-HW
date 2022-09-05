// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetMatrix(int i, int j)
{
    int[,] matrix = new int[i,j];
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
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

void BubleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if(array[j] < array[j + 1])
            {
                int tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
}

void Insert(int row, int[] array, int[,] matrix)
{
    for (int j = 0; j < array.Length; j++)
    {
        matrix[row, j] = array[j];
    }
}

int row = 3;
int column = 4;
int[,] matrix = GetMatrix(row, column);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);
Console.WriteLine();

int[] rowMatrix = new int[column];
for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            rowMatrix[j] = matrix[i,j];
        }
        BubleSort(rowMatrix);
        Insert(i, rowMatrix, matrix);
    }

Console.WriteLine("Отсортированный массив:");
PrintMatrix(matrix);
