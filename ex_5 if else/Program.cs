Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "толик")
{
    Console.WriteLine("Ура, это же Еболик первый день!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
