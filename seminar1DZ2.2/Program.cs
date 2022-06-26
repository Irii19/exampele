// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine();
Console.WriteLine("                           все будет хорошо");
Console.WriteLine();
Console.WriteLine("программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine();

Console.WriteLine("ведите первое (целое) число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе (целое) число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите третье (целое) число");
int numberC = Convert.ToInt32(Console.ReadLine());



if(numberA > numberB)
{
    
    if(numberA > numberC)
    {
        Console.WriteLine(numberA);
    }
    else
    {
        Console.WriteLine(numberC);
    }
}
else
{
    if(numberB > numberC)
    {
        Console.WriteLine(numberB);
    }
    else
    {
        Console.WriteLine(numberC);
    }
}
    


