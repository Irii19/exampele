//////// Дан текст. 
//// В тексте нужно все пробелы заменить черточками, маленькие буквы “к” 
/// заменить большими “К”, а большие “С” заменить маленькими “с”.


//// Ясна ли задача?


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде,вы бы взяли приступом согласие "
            + "прусского короля.Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] 
// c. r

    string Replace(string text, char oldVaalue, char newValue)
//  метод назнание(     текст, символ (oldVaalue)-старый символ,символ(newValue) на который меняют)
{
    string result = string.Empty; 
//  новая строка(result) = string.Empty(инициализацтя пустой строки)

    int length = text.Length;
//   int(новая переменная целого значения) length(её имя) = text.Length(свойство показывающие количество символов в строки)

for (int i = 0; i < length; i++)
// метод переберающий текст
    {
        if(text[i] == oldVaalue) result = result + $"{newValue}";
// если(if) текушщий символ(text[i]) совпал с тем сивлом (oldVaalue),который мы хотим заменить, то в результат (result)
// мы должны положить новое значение(newValue)
        else result = result + $"{text[i]}";
// если совпадений не обнаруженно то наш результат(result) нужно добавить текущий символ(text[i])
    }
    return result;
//  возращение строки
}

string newText = Replace(text, ' ', '|' );
// переменная(строка-string) newText(имя) присвоить= Replace(ранее созданная переменная)(text, " "(char oldVaalue-старое значение), "|"(char newValue-новое значение));

Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(text, 'к', 'К' );
Console.WriteLine(newText);


