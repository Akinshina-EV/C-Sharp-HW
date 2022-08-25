// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа, разделяя их запятой и пробелом, напр имер, 1, 2: ");
int[] numbers = Console.ReadLine().Split(", ").Select(Int32.Parse).ToArray();  
int positiveNumberCount = 0;
foreach (var item in numbers)
{
    if(item > 0)
    {
        positiveNumberCount++;
    }
}
Console.WriteLine($"Количество введенных чисел больше 0 равно {positiveNumberCount}.");
