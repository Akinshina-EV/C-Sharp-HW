// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < 10)
            {
                Console.Write("0" + matrix[i,j] + " ");
            }
            else
            {
                Console.Write(matrix[i,j] + " ");
            }
        }
            Console.WriteLine();
    }
}

int row = 4;
int column = 4;
int[,] spiral = new int[row,column];

int number = 1;
int countNumber = row * column;
    
int rowMin = 0, rowMax = row - 1;
int columnMin = 0, columnMax = column - 1;

while (number <= countNumber) 
{
    for (int i = columnMin; number <= countNumber && i <= columnMax; i++) 
    {
        spiral[rowMin, i] = number++;
    }
    rowMin++;
    for (int i = rowMin; number <= countNumber && i <= rowMax; i++) 
    {
        spiral[i, columnMax] = number++;
    }
    columnMax--;
    for (int i = columnMax; number <= countNumber && i >= columnMin; i--) 
    {
        spiral[rowMax, i] = number++;
    }
    rowMax--;
    for (int i = rowMax; number <= countNumber && i >= rowMin; i--) 
    {
        spiral[i, columnMin] = number++;
    }
    columnMin++;
    }

PrintMatrix(spiral);
