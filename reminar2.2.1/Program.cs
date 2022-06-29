// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.");

Console.WriteLine();

Console.WriteLine("введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввидите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int a = firstNumber % secondNumber;

if (firstNumber % secondNumber == 0 )
{
    Console.WriteLine("второе число кратно первому");
}
else{
    Console.WriteLine($"второе число не кратно первому, остаток =  {a}");}