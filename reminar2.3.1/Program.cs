// See https://aka.ms/new-console-template for more information
Console.WriteLine("которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine ("кротно");
}
else
{
    Console.WriteLine("не кратно");
}