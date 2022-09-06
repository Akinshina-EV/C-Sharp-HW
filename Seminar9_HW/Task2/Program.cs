// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static int GetNumber(string numberName)
{
    Console.WriteLine($"Введите число {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

static int GetSumNaturalNumber(int number1, int number2)
{
    int sum = number1;
    if (number1 >= number2) return sum;
    else
    {
        sum += GetSumNaturalNumber(number1 + 1, number2);
        number1++;
    }
    return sum;
}

int numberA = GetNumber("M");
int numberB = GetNumber("N");
int sumAB = GetSumNaturalNumber(numberA, numberB);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sumAB}");
