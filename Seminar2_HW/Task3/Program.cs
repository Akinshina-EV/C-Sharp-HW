// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
Console.WriteLine("1 - Пн, 2 - Вт, 3 - Ср, 4 - Чт, 5 - Пт, 6 - Сб, 7 - Вс: ");

int numberWeekDay = Convert.ToInt32(Console.ReadLine());
if(numberWeekDay == 6 || numberWeekDay == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
    