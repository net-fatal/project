// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите х1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите х2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double X = Math.Pow(x2 - x1, 2);
double Y = Math.Pow(y2 - y1, 2);
double Z = Math.Pow(z1 - z2, 2);

double length = Math.Sqrt(X + Y + Z);
length = Math.Round(length, 2);
Console.WriteLine($"Длинна отрезка {length}");

