Console.WriteLine("Приветствую ВАС, введите ВАШЕ имя");
string username = Console.ReadLine( );

if (username.ToLower() == "маша")
{
Console.WriteLine("Мы тебя так долго ждали. МАША");
}
else 
{
Console.WriteLine("Привет!!! " + username );
}