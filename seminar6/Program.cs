// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

////////// СЕМИНАР 5
// -----------------


////// Задача. найти произведени пар чисел в масиве и рудьтат записать в новом масив.

// int[] inputArray = { 1, 2, 3, 4, 5 };
// int lastIndex = inputArray.Length - 1;
// int[] resultArray = new int[inputArray.Length / 2 + inputArray.Length % 2];

// for (int i = 0; i < resultArray.Length; i++)
// {
//     resultArray[i] = inputArray[i] * inputArray[lastIndex - i];
//     if (i == lastIndex - i)
//     {
//         resultArray[i] = inputArray[i];
//     }
//     Console.Write ($"{resultArray[i]} ");
// }



//Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];

// for (int i = 0; i < size; i++)
// {
//     res[i] = new Random().Next(minValue, maxValue + 1); // Next(0,11) -> [0;10]
// }
// return res;
// }

// void ReverseArray(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int temp = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = temp;
// }
// }
// ReverseArray(array);
// Console.WriteLine(String.Join(" ", array));

// int[] ReverseCopyArray(int[] inArray)
// {
// int[] result = new int[inArray.Length];
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];
// }
// return result;
// }
// int[] reversArray=ReverseCopyArray(array);
// Console.WriteLine(String.Join(" ", reversArray));

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("введите одну из сторон треугольника");
// int firstSideFriangle = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите одну из сторон треугольника");
// int secondSideTriangle = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите одну из сторон треугольника");
// int thirdSideTriangle = Convert.ToInt32(Console.ReadLine());

// if (firstSideFriangle + secondSideTriangle > thirdSideTriangle
//  && secondSideTriangle + thirdSideTriangle> firstSideFriangle 
//  && thirdSideTriangle + firstSideFriangle > secondSideTriangle) 
// Console.WriteLine("треугольник с такими сторонами существует");

// else Console.WriteLine("треугольник с такими сторонами не существует");



//// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("введите чесло\t");
// int number = Convert.ToInt32(Console.ReadLine());

// int firstNamber = 0;
// int secondNumber = 1;
// Console.WriteLine(firstNamber);
// Console.WriteLine(secondNumber);
// for (int i = 3; i <= number; i++)
// {
//     int nextNumber = firstNamber + secondNumber;
//     Console.WriteLine(nextNumber);
//     firstNamber = secondNumber;
//     secondNumber = nextNumber;
// }


// //Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101   3  -> 11  2  -> 10


void Binari(int number)
{
    string result = "";
    while (number>0)
    {
        result= number%2+ result;
        number/= 2;
    }
    Console.WriteLine(result);

}
 int inputNumber = Convert.ToInt32(Console.ReadLine());
 Binari(inputNumber);