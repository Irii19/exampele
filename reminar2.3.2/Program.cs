// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




// КОРОТКИЙ ВАРИАНТ логическогорешения задачи


// bool IsMultiplicity (int number)
// {
//     return(number%7==0 && number%23==0);
// }
// Console.WriteLine(IsMultiplicity (46));



int number = 1127;

bool IsMultiplicity (int number)
{
    return(number%7==0 && number%23==0);
}
Console.WriteLine(IsMultiplicity (number));