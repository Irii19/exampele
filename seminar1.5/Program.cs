// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");

Console.WriteLine();
Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    int a = number % 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("не верно ведены данные");
}






