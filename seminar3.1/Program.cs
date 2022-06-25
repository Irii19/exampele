// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine ("привет! программа которая будет выдовать названия дня недели, по заданному числу");
Console.WriteLine ("введите интиресующие число");
int number = Convert.ToInt32(Console.ReadLine());

 if (number > 0 && number < 8)
 {
    if (number == 1)
    {
        Console.WriteLine("понедельник");
    }
    if (number == 2)
    {
        Console.WriteLine("вторник");
    }
    if (number == 3)
    {
        Console.WriteLine("среда");
    }
    if (number == 4)
    {
        Console.WriteLine("четверг");
    }
    if (number == 5)
    {
        Console.WriteLine("пятница");
    }
    if (number == 6)
    {
        Console.WriteLine("суббота");
    }
    if (number == 7)
    {
        Console.WriteLine("воскресенье");
    }
}
else 
{
    Console.WriteLine("не верно введенные даннные");
}
