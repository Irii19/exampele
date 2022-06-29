// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.WriteLine();
Console.WriteLine("введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number>= 1 && number<= 5)
{
    Console.WriteLine("этот день не выходной");
}
else
{
    Console.WriteLine("этот день выходной");
}