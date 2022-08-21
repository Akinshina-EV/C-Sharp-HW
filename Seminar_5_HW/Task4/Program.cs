// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}

double min = array[0];
double max = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
    else if(array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(max - min);
