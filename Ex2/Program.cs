// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistanceTwoPoint (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanse = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    
    return distanse;
}
Console.Write("Введи x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введи y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введи z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введи x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введи y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введи z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = GetDistanceTwoPoint (x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстоние между точками {x1}, {y1} и {z1}, {x2}, {y2} и {z2} равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");

