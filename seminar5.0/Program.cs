// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

////////// СЕМИНАР 5
// -----------------


////// 5. Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] myArray = new int [12];
// int size = myArray.Length;

// int positivenumber = 0;
// int negativenumber = 0;

// int index = 0;
// while(index < size){
//     myArray[index] = new Random().Next(-9,10);
//     index++;
// }

// System.Console.WriteLine($"[{string.Join("; ", myArray)}]");
// for(int startindex=0; startindex<size ; startindex++){
//     if (myArray[startindex]>0)
//     {
//         positivenumber+=myArray[startindex];
//         Console.WriteLine($"положительные = {positivenumber}");

//     }
//     else
//     {
//         negativenumber+=myArray[startindex];

//     }
// }
// Console.WriteLine($"сумма положительных чисел = {positivenumber}");
// Console.WriteLine($"сумма отрицательных чисел = {negativenumber}");


////// 5. Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int [] myarray = new [] {1,2,3,4,5,6};
// Console.WriteLine($"[{string.Join("; ", myarray)}]");
// for(int i =0; i<myarray.Length; i++){
//     myarray[i]*=-1;
// }
// Console.WriteLine($"[{string.Join("; ", myarray)}]");


// /////  5. Задача 33: Задайте массив. Напишите программу, которая 
//  определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// // ВАРИАНТ 1
// // РАБОТАЕТ
// int [] myarray = new [] {1,2,3,4,5,6};
// Console.WriteLine($"[{string.Join("; ", myarray)}]");

//  Console.Write("введите число для проверки ");
//  int number = Convert.ToInt32(Console.ReadLine());
//  int size = myarray.Length;

//  int index = 0;
//  while (index<size)
//  {
//     index++;
    
//     if (myarray[index] == number)
//     {
//         Console.WriteLine("число присутсвут в массиве");
//     }
//     else
//     {
//         Console.WriteLine("число отсутствует в массиве");

//     }
//  }

// //ВАРИАНТ 2
// int [] myarray = new [] {1,2,3,4,5,6};
// Console.WriteLine($"[{string.Join("; ", myarray)}]");
// int number = new Random().Next(1, 10);
// Console.WriteLine(number);
// bool flagResult = true; // true - найдено, ложь- не найдено
// for (int i = 0; i < myarray.Length; i++)
// {
//     if(number == myarray[i])
//     {
//         flagResult = true;
//         break;
//     }
//     else
//     {
//         flagResult = false;
//     }

// }
// // Console.WriteLine(flagResult);
// if(flagResult) Console.WriteLine($"{flagResult}: элемент {number} присутствует");
// else Console.WriteLine($"{flagResult}: элемент {number} не присутствует");


////// 5. Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1    [1, 2, 3, 6, 2] -> 0

////// не работает
int [] myarray = new int [10];
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new Random().Next(1, 200);
}
Console.WriteLine($"[{string.Join(", ", myarray)}]");
int index = 0;
int count = 0;
while (index< myarray.Length)
{
    index++;
    if(myarray[index]>=10 && myarray[index]<=99)
    {
        count++;
    }
}
Console.WriteLine(count);

// int [] myarray = new int [10];
// int count = 0;

// for (int i = 0; i < myarray.Length; i++)
// {
//     myarray[i] = new Random().Next(1, 200);
//     if(myarray[i]>=10 && myarray[i]<=99){
//         count++;
//     }
// }
// Console.WriteLine($"[{string.Join(", ", myarray)}] , количество: {count}");
