// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// апишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("введите число");

int numberA = Convert.ToInt32(Console.ReadLine());
int oppositenumberA = numberA * (-1);

Console.WriteLine();

while(oppositenumberA  <= numberA)
{
    Console.WriteLine(oppositenumberA);
    oppositenumberA = oppositenumberA + 1; //  можно и так oppositenumberA += 1;
}
