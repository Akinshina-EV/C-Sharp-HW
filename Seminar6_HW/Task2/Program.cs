// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

static double GetCoefficient(string coefName)
    {
        Console.WriteLine($"Введите значение коэффициента {coefName}: ");
        return double.Parse(Console.ReadLine());        
    }

Console.WriteLine("Даны уравнения двух прямых: ");
Console.WriteLine("y = k1 * x + b1"); 
Console.WriteLine("y = k2 * x + b2"); 

double b1 = GetCoefficient("b1");
double k1 = GetCoefficient("k1");
double b2 = GetCoefficient("b2");
double k2 = GetCoefficient("k2");

if(k1 == k2)
{
    Console.WriteLine("Обе прямые заданы уравнениями с угловым коэффициентом." +
    "Так как k1 = k2, то прямые параллельны. Так как эти прямые не совпадают то точек пересечения нет.");
}
else
{
double coordinateX  = (b2 - b1) / (k1 - k2);
double coordinateY = (k2 * (b2 - b1)) / (k1 - k2) + b2;
Console.WriteLine("Координаты точки пересечения двух прямых, заданных уравнениями:  ({0};  {1})", coordinateX, coordinateY);
}
