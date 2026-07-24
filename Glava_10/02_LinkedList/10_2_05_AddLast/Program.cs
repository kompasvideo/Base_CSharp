var company = new LinkedList<Person>();

company.AddLast(new Person("Tom"));
company.AddLast(new Person("Sam"));
company.AddFirst(new Person("Bill"));

foreach (var person in company)
Console.WriteLine(person.Name);

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}