// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




// КОРОТКИЙ ВАРИАНТ логическогорешения задачи


// bool IsMultiplicity (int number)
// {
//     return(number%7==0 && number%23==0);
// }
// Console.WriteLine(IsMultiplicity (46));



// МОЖНО И ТАК, через консоль


// Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// bool IsMultiplicity (int number)
// {
//     return(number%7==0 && number%23==0);
// }
// Console.WriteLine(IsMultiplicity (number));


// МОЖНО И ТАК, ЧЕРЕЗГЕНЕРАТОР СЛУЧАЙНЫХ ЧИСЕЛ


int number = new Random().Next(100, 1000);
Console.WriteLine(number);

bool IsMultiplicity (int number)
{
    return(number%7==0 && number%23==0);
}
Console.WriteLine(IsMultiplicity (number));


