// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 18: Напишите программу, которая по заданному номеру четверти, ");
Console.WriteLine("показывает диапазон возможных координат точек в этой четверти (x и y)");
Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());

if(n>=1 && n<=4){
    if(n==1){
        Console.WriteLine("x>0 , y>0");}
    if(n==2){
        Console.WriteLine("x<0 , y>0");}
    if(n==3){
        Console.WriteLine("x<0 , y<0");}
    if(n==4){
        Console.WriteLine("x>0 , y<0");}}
else{
    Console.WriteLine("нет такой четверти");}