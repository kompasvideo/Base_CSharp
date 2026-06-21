List<Person> persons = new List<Person>()
{
    new Person("Tom"),
    new Person("Bob"),
    new Person("Sam")
};

class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}