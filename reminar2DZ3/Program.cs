// See https://aka.ms/new-console-template for more information
// Console.WriteLine("программа, которая выводит третью цифру заданного числа или сообщает,");
// Console.WriteLine("что третьей цифры нет.  645 -> 5  78 -> третьей цифры нет    32679 -> 6");

// Console.WriteLine("ведите целое число");

// Console.WriteLine();

// string n = Console.ReadLine();
// // if (number > 100)
// // {
//     Console.WriteLine($"третья цифра -   {n[2]}");
// // }
// // else
// // {
//     Console.WriteLine("третьей цифры нет");
// // }



Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
