// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число - {number}");

int digitOne = number / 10;
int digitTwo = number % 10;
Console.WriteLine(digitOne);
Console.WriteLine(digitTwo);

int max = Math.Max(digitOne, digitTwo);
Console.WriteLine($"наибольшее число: {max}, кто не понял, наибольшее число {max}");