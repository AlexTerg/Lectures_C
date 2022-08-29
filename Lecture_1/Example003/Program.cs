Console.Write("Введите имя пользователя: ");
string name = Console.ReadLine();

if (name.ToLower() == "маша")
{
    Console.Write("Ура это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}