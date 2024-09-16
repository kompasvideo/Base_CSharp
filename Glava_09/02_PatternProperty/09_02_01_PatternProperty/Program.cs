Person tom = new Person { Language = "english", Status = "user", Name = "Tom" };
Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };

SayHello(tom);          // Hello
SayHello(pierre);       // Salut

void SayHello(Person person)
{
    if(person is Person { Language: "french"})
    {
        Console.WriteLine("Salut");
    }
    else
    {
        Console.WriteLine("Hello");
    }
}

class Person
{
    public string Name { get; set; } = "";      // имя пользователя
    public string Status { get; set; } = "";    // статус пользователя
    public string Language { get; set; } = "";  // язык пользователя
}