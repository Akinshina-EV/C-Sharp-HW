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
int count = row * column;
    
int rmin = 0, rmax = row - 1;
int cmin = 0, cmax = column - 1;

while (number <= count) 
{
    for (int i = cmin; number <= count && i <= cmax; i++) 
    {
        spiral[rmin, i] = number++;
    }
    rmin++;
    for (int i = rmin; number <= count && i <= rmax; i++) 
    {
        spiral[i, cmax] = number++;
    }
    cmax--;
    for (int i = cmax; number <= count && i >= cmin; i--) 
    {
        spiral[rmax, i] = number++;
    }
    rmax--;
    for (int i = rmax; number <= count && i >= rmin; i--) 
    {
        spiral[i, cmin] = number++;
    }
    cmin++;
    }

PrintMatrix(spiral);
