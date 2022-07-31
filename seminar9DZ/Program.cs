

///////// ДОМАШНЯЯ РАБОТА

////// Задача 64: 

// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Задача 66: 

// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: 

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


////// Задача 64: 

// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.Write("введите число для начала отсчёта: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число для оконания отчетв: ");
// int end = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(int start, int end)
// {
//     if(start>end) Console.WriteLine("так не чего не выйдет");
//     break;
    
//     if(start == end) return end.ToString();
//     return start + "; " + PrintNumber(start + 1, end);
// }
// System.Console.WriteLine(PrintNumber(start, end));


// // Задача 66: 

// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("введите число для начала отсчёта: ");
int startReport = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число для оконания отчета: ");
int endReport = Convert.ToInt32(Console.ReadLine());

int Sum(int start, int end)
{
    if(start > end) return 0;
    return start + Sum(start + 1, end);
}
Console.WriteLine(Sum(startReport, endReport));


