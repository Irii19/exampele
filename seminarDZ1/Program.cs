// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("через тернии к звёздам");
Console.WriteLine("программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine("ведите первое (целое) число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе (целое) число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB){
    Console.WriteLine("большее число " + numberA);
    Console.Write("меньшее число " + numberB);
}
else{
    Console.WriteLine("большее число " + numberB);
    Console.Write("меньшее число " + numberA );
}