// See https://aka.ms/new-console-template for more information
Console.WriteLine("               вперед, вперед и только в перед!!!");

Console.WriteLine("программа, которая на вход принимает число и выдаёт, является ли число чётным");


Console.WriteLine("Введите число: ");

int c = Convert.ToInt32(Console.ReadLine());

if (c % 2 == 0) 
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число нечетное");
}
