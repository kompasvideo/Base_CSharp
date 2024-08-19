var person = new Person("Tom", 37);
Console.WriteLine(person.Name);     // 37

var (personName, personAge) = person;
Console.WriteLine(personAge);       // 37
Console.WriteLine(personName);      // Tom

public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
}
