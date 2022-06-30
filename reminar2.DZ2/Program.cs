// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное ");
Console.WriteLine("число и на выходе показывает вторую цифру этого числа");

Console.WriteLine();
Console.WriteLine("введите трехзначное чило");
Console.WriteLine("");
int number = Convert.ToInt32(Console.ReadLine());

int numberA = number / 10;

// МОЖНО И ТАК, НО ДАВАЙ ПОПРОБУЕМ ПО ДРУГОМУ
// int numberB = numberA % 10;
// Console.WriteLine(numberB);

Console.WriteLine($"вторая цифра по порядку {numberA % 10}");



