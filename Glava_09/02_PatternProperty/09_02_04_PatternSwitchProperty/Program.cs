Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
string message = GetMessage(pierre);
Console.WriteLine(message);             // Salut, Pierre!

Person tomas = new Person { Language = "german", Status = "admin", Name = "Tomas" };
Console.WriteLine(GetMessage(tomas));   // Hello, admin!

Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo" };
Console.WriteLine(GetMessage(pablo));   // Unknown language: spanish

Console.WriteLine(GetMessage(null));   // null
string GetMessage(Person? p) => p switch
{
    { Language: "german", Status: "admin" } => "Hello, admin!",
    { Language: "french", Name: var name } => $"Salut, {name}",
    { Language: var lang } => $"Unknown language: {lang}",
    null => "null"          // если Person p = null
};

class Person
{
    public string Name { get; set; } = "";      // имя пользователя
    public string Status { get; set; } = "";    // статус пользователя
    public string Language { get; set; } = "";  // язык пользователя
}