Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "катя")
{
    Console.WriteLine("Здравствуй, дорогая!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}