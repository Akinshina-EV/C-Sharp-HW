// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > -100 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if(number < 0)
    {
        number = - 1 * number;
    }
    string thirdDigit = Convert.ToString(number);
    Console.WriteLine(thirdDigit[2]);
}
