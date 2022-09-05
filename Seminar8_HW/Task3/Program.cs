// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

Console.WriteLine("Даны две матрицы:");
int[,] matrixA = GetMatrix(2,2,1,10);
int[,] matrixB = GetMatrix(2,2,1,10);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();

int[,] matrixAB = new int[matrixA.GetLength(1), matrixB.GetLength(0)];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        for (int k = 0; k < matrixB.GetLength(0); k++)
        {
            matrixAB[i,j] += matrixA[i,k] * matrixB[k,j];
        }         
    }
}
Console.WriteLine("Произведение двух матриц:");
PrintMatrix(matrixAB);
