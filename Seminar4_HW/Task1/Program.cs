// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

static int GetNumber(string numberName)
{
Console.WriteLine("Введите число " + numberName + ": ");
return Convert.ToInt32(Console.ReadLine());     
}

int numberA = GetNumber("A");
int numberB = GetNumber("B");

int power = 1;

for(int i = 0; i < numberB; i++)
{
    power *= numberA;
}
Console.WriteLine(power);
