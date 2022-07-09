// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// Console.WriteLine("введите число для залдания длины массива");int size = Convert.ToInt32(Console.ReadLine());int [] array = {size};Console.WriteLine($"[{string.Join("; ", array)}]");


int [] array = GetBinaryArray(10);
System.Console.WriteLine($"[{string.Join("; ", array)}]");
int [] GetBinaryArray(int size)
{
    int[] resultArrey = new int [size];
    for (int i  =0; i <size; i++){
        resultArrey[i]= new Random().Next(0,2);

    }
    return resultArrey;
}