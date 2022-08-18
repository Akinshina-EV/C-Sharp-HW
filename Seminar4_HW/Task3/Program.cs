// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Данную задачу, как говорит нам Google, можно решить в три строки:
// Console.WriteLine("Введите числа через запятую, которые требуется записать в массив: ");
// int[] array = Console.ReadLine().Split(',').Select(Int32.Parse).ToArray();  
// Console.WriteLine("[{0}]", string.Join(", ", array));

//Но, если надо использовать цикл, то программа будет выглядить вот так:

Console.WriteLine("Введите числа через запятую, которые требуется записать в массив: ");
int[] array = Console.ReadLine().Split(',').Select(Int32.Parse).ToArray();  
Console.Write("[");  
for(int i = 0; i < array.Length-1; i++)
{
Console.Write(array[i] + ", ");  
}
Console.WriteLine(array[array.Length-1] + "]");
