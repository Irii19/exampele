// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////// ДОМАШНЕЕ ЗАДАНИЕ 7
////// ------------------

//// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.  m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



//// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.  m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк массива: n = ");
// int rowsM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцы массива: m = ");
// int columnsN = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double[rowsM,columnsN];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     Console.WriteLine();
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         // matrix[i,j] = new Random().NextDouble()*100 -40;
//         matrix[i,j] = Math.Round(new Random().NextDouble()*100 -40, 1);
//         Console.Write(matrix[i,j] + "\t");
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

///  ВАРИАНТ 1  как понял первый раз

int [,] matrix = new int[4,4];
Console.Write("Введите позицию в строке массива: ");
int positionRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в столбце массива: ");
int positionColumns = Convert.ToInt32(Console.ReadLine());
Console.Write($"\n[{positionRows},{positionColumns}]");
Console.WriteLine();

int meaning = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(10,100);
        Console.Write(matrix[i,j] + "\t");

         if( positionRows == i && positionColumns == j)
         {
            meaning = matrix[i,j];
         }             
         if( positionRows != i && positionColumns != j)
         {
           
         }
    }
}
Console.WriteLine();
Console.WriteLine($" \n [{positionRows},{positionColumns}] == {meaning}");

////// ВАРИАНТ 2

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите интересующие число : ");
// int number = Convert.ToInt32(Console.ReadLine());

// int [,] GetArrey (int m, int n, int minValue, int maxValue)
// {
//    int [,] matrix = new int[m,n];
//    for (int i = 0; i < m; i++)
//    {
//       Console.WriteLine();
//       for (int j = 0; j < n; j++)
//       {
//          matrix[i,j] = new Random().Next(minValue,maxValue +1);
//          Console.Write(matrix[i,j] + "\t");
//       }
//    }
//    return matrix;
// }

// void FagResultArray (int [,] inputArray)
// {
//    bool flagResult = false;
//    for (int i = 0; i < inputArray.GetLength(0); i++)
//    {
//       Console.WriteLine();
//       for (int j = 0; j < inputArray.GetLength(1); j++)
//       {
//          Console.Write(inputArray[i,j] + "\t");
//          if (number == inputArray[i,j]){
//             flagResult = true;
//             break;}
 
//       }
//    }
// if(flagResult) Console.WriteLine($"\n{number} -> такое число в массиве есть");
// else Console.WriteLine($"\n{number} -> такого числа в массиве нет");
// }

// int [,] array = GetArrey(rows,columns, 0, 10);
// FagResultArray(array);


///// ВАРИАНТ 3


// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите интересующие число : ");
// int number = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows,columns];
// bool flagResult = false;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     Console.WriteLine();
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//          matrix[i,j] = new Random().Next(10,13);
        
//          if (number == matrix[i,j])
//          {
//             flagResult = true;
//             break;
//          }
//         Console.Write(matrix[i,j] + "\t");
//     }
   
// }
// Console.WriteLine();
// if(flagResult) Console.WriteLine($"\n{number} -> такое число в массиве есть");
// else Console.WriteLine($"\n{number} -> такого числа в массиве нет");











//// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// cреднее арифметическое элементов в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] matrix = new int[4,4];
// int arithmeticMean = 0;
// // Console.Write($"\nCреднее арифметическое:\n");
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    Console.WriteLine();
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i,j] = new Random().Next(1,10);
//       Console.Write(matrix[i,j] + "\t");
      
     
//    }
  
// }
