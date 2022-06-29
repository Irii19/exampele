// See https://aka.ms/new-console-template for more information
Console.WriteLine(" которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");

Console.WriteLine();

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int SearchResult(int number){
    int first = number / 100;
    int third = number % 10;
    return first*10 + third;}
Console.WriteLine(SearchResult(number));

