// See https://aka.ms/new-console-template for more information

// ПЕРВЫЙ ВАРИАНТ

Console.WriteLine("Hello, World!");

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;

// int a2 = 12;
// int b2 = 2223;
// int c2 = 33;

// int a3 = 313;
// int b3 = 22;
// int c3 = 36;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = b2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);

// ВТОРОЙ ВАРИАТ: ФУНКЦИЯ

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39456;

// int a2 = 12;
// int b2 = 2223;
// int c2 = 33;

// int a3 = 313;
// int b3 = 2747962;
// int c3 = 36;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);
// // можно и по другому

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

// Console.WriteLine(max);

// ТРЕТИЙ ВАРИАНТ: МАССМИВ

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//             0   1   2   3    4   5   6   7   8
int[] arrey = {11, 211, 31, 41, 15, 61, 17, 18, 19};
arrey[0] = 12; // новое значения индека "0"
Console.WriteLine(arrey[0]);  // вывод индекса значения "0"
Console.WriteLine(); // пустая строчка
Console.WriteLine(arrey[2]);// вывод индекса значения "2"
Console.WriteLine(); // вывод индекса значения "0"
for (int i = 0; i < arrey.Length; i++) // пересчёт массива
{
    Console.WriteLine(arrey[i]); // вывод нового массива
}

int result  = Max(                       // нахождения максимального значиния числа из массива
    Max(arrey[0], arrey[1], arrey[2]),
    Max(arrey[3], arrey[4], arrey[5]),
    Max(arrey[6], arrey[7], arrey[8]));

Console.WriteLine();
Console.WriteLine(result); // вывод максимальго значения
