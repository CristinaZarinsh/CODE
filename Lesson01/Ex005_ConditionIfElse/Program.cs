Console.Write("Введите имя пользователя: ");
string usename = Console.ReadLine();

if(usename.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(usename);
}