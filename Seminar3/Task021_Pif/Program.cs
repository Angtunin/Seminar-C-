// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите xa: ");
int xa = int.Parse(Console.ReadLine());
Console.Write("Введите ya: ");
int ya = int.Parse(Console.ReadLine());
Console.Write("Введите xb: ");
int xb = int.Parse(Console.ReadLine());
Console.Write("Введите yb: ");
int yb = int.Parse(Console.ReadLine());

double D = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));
Console.WriteLine($"{D:f2}");


