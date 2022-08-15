// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
if(number == new string (number.Reverse().ToArray()))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
