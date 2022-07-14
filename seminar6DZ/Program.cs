// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

///////// ДОМАШНЯЯ ЗАДАНИЕ 6
//////// -------------------

// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2   -1, -7, 567, 89, 223-> 3
// Console.Write("определите количество чисел которые хотите ввести:\t");

// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     Console.Write($"введите элеиент массива под индексом {i}:\t");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if (array[i] > 0)
//     {
//         count++;
//     }

// }
// Console.WriteLine($"\n[{string.Join("; ", array)}]");
// Console.WriteLine($"\nколичество положительных чисел: {count}");


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("введите значения переменной b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значения переменной k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значения переменной b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значения переменной k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;
 
Console.Write($"\n({x}; {y})");


// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

