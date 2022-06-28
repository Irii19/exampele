// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine ("у тебя все получится!!!");
Console.WriteLine ("ведите первое число");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("ведите второе число");
int numberB = Convert.ToInt32(Console.ReadLine ());

if (numberA == numberB * numberB)
{
Console.WriteLine ("второе число является квадратом первого");
}
else 
{
    Console.WriteLine ("второе число не является квадратом певого");
}