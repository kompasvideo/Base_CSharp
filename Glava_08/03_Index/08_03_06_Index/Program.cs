var microsoft = new Company(new Person[] { new("Tom"), new("Bob"), new("Sam") });
Console.WriteLine(microsoft[0].Name);       // Tom
Console.WriteLine(microsoft["Bob"].Name);   // Bob

class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;    
}
class Company
{
    Person[] personal;
    public Company(Person[] people) => personal = people;
    // индексатор
    public Person this[int index]
    {
        get => personal[index];
        set => personal[index] = value;
    }
    public Person this[string name]
    {
        get
        {
            foreach (var person in personal)
            {
                if (person.Name == name) return person;
            }
            throw new Exception("Unknown name");
        }
    }
}