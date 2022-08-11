// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Самый короткий вариант, но не работает при отрицательных числах, а также если ввести лишние пробелы:
// Console.Write("Введите трехзначное число: ");
// string number = Console.ReadLine();
// Console.WriteLine(number[1]);

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;
if(number < 0)
{
    secondDigit = -1 * number % 100 / 10;
}
else
{
    secondDigit = number % 100 / 10;
}
Console.WriteLine(secondDigit);
