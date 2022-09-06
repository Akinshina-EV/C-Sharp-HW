// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

static int GetNumber(string numberName)
{
    Console.WriteLine($"Введите число {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

static void GetNaturalNumber(int number1, int number2)
{
    if (number1 > number2) return;
    Console.Write($"{number1} ");
    GetNaturalNumber(number1 + 1, number2);
}

int numberA = GetNumber("M");
int numberB = GetNumber("N");
Console.WriteLine($"Все натуральные числа в промежутке от M до N: ");
GetNaturalNumber(numberA, numberB);
