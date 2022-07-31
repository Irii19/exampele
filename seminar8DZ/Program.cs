// // See https://aia.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// На оценку "5" нужно сделать минимум 4 задачи

// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


////// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] GetArrey (int m, int n, int minValue, int maxValue)
// {
   // int [,] matrix = new int[m,n];
   // for (int i = 0; i < m; i++)
   // {
   //    Console.WriteLine();
   //    for (int j = 0; j < n; j++)
   //    {
   //       matrix[i,j] = new Random().Next(minValue,maxValue +1);
   //       Console.Write(matrix[i,j] + "\t");
   //    }
   // }
//    return matrix;
// }

// void ArrangeRowsAscendingArray (int [,] inputArray)
// {
//     
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         int sum = 0;        
//         Console.WriteLine();
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             sum += inputArray[i, j];
//             Console.Write(inputArray[i ,j] + "\t");
                                    
//         }   
//          Console.Write(sum);

//       }
//       
// // if(flagResult) Console.WriteLine($"\n{number} -> такое число в массиве есть");
// // else Console.WriteLine($"\n{number} -> такого числа в массиве нет");
// // Console.Write("Минимальное значение: " + sum);
// }

// int [,] array = GetArrey(rows,columns, 0, 10);
// System.Console.WriteLine();
// ArrangeRowsAscendingArray(array);

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows,columns];
// int [] A = new int [rows];
// // int number = 0;

//    for (int i = 0; i < rows; i++)
//    {
//       int rowsMax = 0;
//       Console.WriteLine();
//       for (int j = 0; j < columns; j++)
//       {
//          matrix[i,j] = new Random().Next(0,11);
//          rowsMax += matrix[i,j];
//          //number = matrix[i,j];
//          Console.Write(matrix[i,j] + "\t");
         
//       }
//    Console.Write(rowsMax);
//   /// System.Console.WriteLine(number);

//    }
//    // Console.Write(number);

//    System.Console.WriteLine();
//    System.Console.WriteLine();

//     for (int i = 0; i < rows; i++)
//    {
//       A[i] = matrix[i,1];
//       for (int j = 0; j < columns ; j++)
//       {
//          if(A[i] < matrix[i,j])
//          {
//             A[i] = matrix[i,j];
//             //A[i] = number;

//          }
//       }
//       Console.Write(A[i] + "\t");
//   }





// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

//// РАБОТАЕТ

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// int [,] matrix = new int[rows,columns];
// int rowsMatrix = 0;
// int min = int.MaxValue;
//    for (int i = 0; i < rows; i++)
//    {
//        int sum = 0;
       
//       for (int j = 0; j < columns; j++)
//       {
//          matrix[i,j] = new Random().Next(0,11);

//          sum +=matrix [i, j];

//          Console.Write(matrix[i,j] + "\t");

//          if (sum < min )
//          {
//             min = sum;
//             rowsMatrix = i+1;           
//          }
//       }   
//          System.Console.WriteLine();
//    }

// System.Console.WriteLine();
// Console.WriteLine($"номер строки с наименьшей суммой элементов это - {rowsMatrix}");

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// РАБОТАЕТ


// int [,,] matrix = new int [3,4,5];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    Console.WriteLine("слой " + i);
      
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.WriteLine();
//       for (int k = 0; k < matrix.GetLength(2); k++)
//       {
         
//          matrix[i,j,k] = new Random().Next(100);
//          Console.Write(matrix[i, j, k] + $" ({i}, {j}, {k})" + "\t");
        

//       }
//    }
//    Console.WriteLine();
//    Console.WriteLine("-----------------------------------------------------------------------------");
   
// }

////// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// РАБОТАЕТ

// int [,] firstMatrix = new int[4,4];
// int [,] secondMatrix = new int [4,4];
// int [,] resultMatrix = new int [4,4];

// for (int i = 0; i < 4; i++)
// {
//    Console.WriteLine();
//    for (int j = 0; j < 4; j++)
//    {
//       firstMatrix[i,j] = new Random().Next(0,11);
      
   
//       Console.Write(firstMatrix[i,j] + "\t");
      
//    }
  
// }
// System.Console.WriteLine();

// for (int i = 0; i < 4; i++)
// {
//    Console.WriteLine();
//    for (int j = 0; j < 4; j++)
//    {
//       secondMatrix[i,j] = new Random().Next(0,11);

//       Console.Write(secondMatrix[i,j] + "\t");
         
//    }
  
// }
// System.Console.WriteLine();

// for (int i = 0; i < 4; i++)
// {

//    Console.WriteLine();
//    for (int j = 0; j < 4; j++)
//    {
//       resultMatrix[i,j] = firstMatrix[i,j]* secondMatrix[i,j];
   
//       Console.Write(resultMatrix[i,j] + "\t");
      
//    }
  
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:


Console.Clear();
Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, ");
Console.WriteLine($"которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}