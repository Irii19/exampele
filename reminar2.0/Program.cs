Console.WriteLine("Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.");

int number = new Random().Next(10,100);
Console.WriteLine(number);

int a = number /10;
Console.WriteLine(a);
int b = number % 10;
Console.WriteLine(b);

if (a > b)
{
    Console.WriteLine("наивольшее число " + a);
}
else
{
    Console.WriteLine("наибольшее число " + b);
}