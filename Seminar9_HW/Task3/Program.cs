// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

static int GetNumber(string numberName)
{
    Console.WriteLine($"Введите неотрицательное число {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

static int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
    else return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
}

int numberA = GetNumber("m");
int numberB = GetNumber("n");

int result = FuncAkkerman (numberA, numberB);
Console.WriteLine(result);
