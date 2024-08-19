var tom = new Person("Tom", 37);
var sam = tom with { Name = "Sam" };
Console.WriteLine($"{sam.Name} - {sam.Age}");   // Sam - 37

var person = tom with { };
Console.WriteLine($"{person.Name} - {person.Age}");   // Tom - 37

public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}