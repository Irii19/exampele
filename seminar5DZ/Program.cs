// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


////// ДОМАШНЯЯ РАБОТА
// 5. Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] myarray = new int [10];

// int count = 0;
// for (int i = 0; i < myarray.Length; i++)
// {
//     myarray[i] = new Random().Next(99, 1000);
//     if(myarray[i]%2== 0){
//         count++;
//     }

// }
// Console.WriteLine($"[{string.Join(", ", myarray)}]");
// Console.WriteLine($"количество четных чисел =  {count}");

// 5. Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0

// Console.Write("введите число, которому будет соответсвовать количество элементов в масиве ");
// int elements = Convert.ToInt32(Console.ReadLine());

// int [] myarray = new int [elements];
// int sum = 0;
// System.Console.WriteLine( $"[{string.Join(", ", myarray)}]");
// for (int i = 0; i < myarray.Length; i++)

// {
//     myarray[i] = new Random().Next(-10,10);

//     if(i %2 !=0)
//     {
//         sum+=myarray[i];
//     }
    
// }
// System.Console.WriteLine( $"[{string.Join(", ", myarray)}]");
// System.Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Console.Write("введите число, которому будет соответсвовать количество элементов в масиве ");
// double [] myarray = new double [8];
// double max = myarray[0];
// double min = myarray[0];

//// ВАРИАНТ 1
// for (int i = 0; i < myarray.Length; i++)
// {
//    myarray[i] = new Random().NextDouble();
//    max = myarray.Max();
//    min = myarray.Min();
//    }
// Console.WriteLine( $"[{string.Join(", ", myarray)}]");
// Console.WriteLine();
// Console.WriteLine(max);
// Console.WriteLine(min);
// Console.WriteLine();
// Console.WriteLine($"разница между максимальным и минимальным значение: {max - min} ");

//// ВАРИАНТ 2

Console.Write("введите чесло для создания массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] myarray = new double [size];

for (int i = 0; i < myarray.Length; i++)
{
   myarray[i] = new Random().NextDouble();
}

 Console.WriteLine( $"[{string.Join(", ", myarray)}]");
 double max = myarray[0];
double min = myarray[0];

for (int i = 1; i < myarray.Length; i++)
{
   if ( max < myarray[i] )
   {
      max = myarray[i];
   }
   if (min > myarray[i])
   {
      min = myarray[i];
   }
}
 

Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным значение: {max - min} ");