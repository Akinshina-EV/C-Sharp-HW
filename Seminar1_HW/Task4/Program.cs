//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int input_number = Convert.ToInt32(Console.ReadLine());

int number = 1;
while(number <= input_number)
{
    if(number % 2 == 0)
    {
        Console.Write($"{number} ");
    }
    number++;
}
