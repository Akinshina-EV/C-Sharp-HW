// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
Console.WriteLine("[{0}]", string.Join(", ", array));

int len = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(array.Length)/2));
int[] newArray = new int[len];

for (int i = 0; i < len; i++)
    {
        if (array.Length % 2 != 0 && i == len - 1)
        {
            newArray[i] = array[i];
        }
        else 
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];
        }
    }
Console.WriteLine("[{0}]", string.Join(", ", newArray));

