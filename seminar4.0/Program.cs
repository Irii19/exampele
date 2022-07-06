// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28      4 -> 10      8 -> 36

Console.WriteLine("введите число");
int A = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int count =0;
// for(int i = 1; i<=A; i++){
//     sum+=i;
//     count++;
// }

int sum = 0;
int i = 1;
int count =0;
while ( i<=A){
    i++;
    sum+=i;
    count++;
}

 Console.WriteLine(sum);
 System.Console.WriteLine();
 System.Console.WriteLine("соличество итервций " + count);


