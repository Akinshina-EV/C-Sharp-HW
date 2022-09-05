// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int massiveSize1 = 2;
int massiveSize2 = 2;
int massiveSize3 = 2;
Console.WriteLine($"Массив размером {massiveSize1} x {massiveSize2} x {massiveSize3}");

Random rnd = new Random();
int[] random = new int[massiveSize1*massiveSize2*massiveSize3];
random[0] = rnd.Next(10, 100);
    for (int i = 1; i < massiveSize1*massiveSize2*massiveSize3;)
    {
        int number = rnd.Next(10, 100); 
        int j;

        for (j = 0; j < i; j++)
        {
          if (number == random[j])
            break; 
        }
        if (j == i)
        { 
          random[i] = number; 
          i++; 
        }
    }

int[,,] massive = new int[massiveSize1, massiveSize2, massiveSize3];

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        for (int k = 0; k < massive.GetLength(2); k++)
        {
            massive[i,j,k] = random[k + j * massiveSize3 + i * massiveSize2 * massiveSize3];
        }
    }
}
Console.WriteLine();
for (int k = 0; k < massive.GetLength(2); k++)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    } 
}
