// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек");
Console.WriteLine("находит расстояние между ними в 2D пространстве.");

Console.WriteLine("введите координаты точки ax.");

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

Console.WriteLine();
Console.WriteLine(Math.Round(d));