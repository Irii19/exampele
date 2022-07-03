
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("введите число");
// int n =Convert.ToInt32(Console.ReadLine());

// if(int x = 0; x>5; x++)
// {
//     if(n==1){
//         Console.WriteLine("x>0 , y>0");
//     }
//     if(n==2){
//         Console.WriteLine("x<0 , y>0");
//     }
//     if(n==3){
//         Console.WriteLine("x<0 , y<0");
//     }
//     if(n==4){
//         Console.WriteLine("x>0 , y<0");
//     }
// }
// else
// {
//     Console.WriteLine("нет такой четверти");
// }

Console.WriteLine("введите число к коодинату x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число в координату y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
