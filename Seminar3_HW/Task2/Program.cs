// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program
{
    static double[] GetCoordinates(string pointName)
    {
    Console.WriteLine("Введите координаты точки " + pointName + " через запятую, например: 1,2,3: ");
    return Console.ReadLine().Split(',').Select(double.Parse).ToArray();        
    }
    
    static double DiffSqrd(double coordinateA, double coordinateB)
    {
        double diffSqrd = Math.Pow(coordinateB - coordinateA, 2);
        return diffSqrd;
    }

    static void Main()
    {
    double[] pointA = GetCoordinates("A");
    double[] pointB = GetCoordinates("B");

    double distanceAB = Math.Sqrt(DiffSqrd(pointA[0], pointB[0]) + DiffSqrd(pointA[1], pointB[1]) + DiffSqrd(pointA[2], pointB[2]));
    Console.WriteLine(Math.Round(distanceAB, 2));
    }
}
