// See https://aka.ms/new-console-template for more information

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]




////// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// Console.Write("введите первое число: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());

// double result = Math.Pow(firstnumber,secondnumber);
// Console.Write("первое число в степени второго числа равно " + result);


////// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]   6, 1, 33 -> [6, 1, 33]

// int [] myArray;
// myArray = new int [8];
//  - int [] myArray = new int [8];

// или так без for() и new Random().

// - int [] myArray = new [] {1,2,3,4,5,6};
// - int [] myArray = {1,2,3,4,5,6};
// - int [] myArray = new int [] {1,2,3,4,5,6,7,8,9,10,11};
// - int [] myArray = new int [8] {1,2,3,4,5,6,7,8};
// - int [] myArray = new int [8]; запорниться нулями


// Console.WriteLine("введите количество элементов массива ");
// Console.Write("нужно 8, но введите любое число больше 3: ");
// int elements = Convert.ToInt32(Console.ReadLine());

// int [] myArray = new int [elements];
// for(int i = 0; i< elements; i++ ){
//     myArray[i] = new Random().Next(10,20);}
// myArray[1] = 345;
// int number = myArray[2];

// System.Console.WriteLine($"[{string.Join(", ", myArray)}]");
// System.Console.WriteLine(number);

////// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11  82 -> 10   9012 -> 12
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0){
int num = number % 10;
number = number / 10;
Console.WriteLine(sum = sum + num);}
Console.Write($"сумма чисел: {sum}");

