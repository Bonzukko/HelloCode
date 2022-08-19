Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // команда .ToLower() - переводит все символы в нижний регистр, и Машу будет приветствовать вне зависимости от регистра написания любой из букв в этом имени, хоть маША

{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}