Person person = new Person("Tom");
person.Print(); // Tom
person = new Employee("Sam", "Microsoft");
person.Print(); // Sam

// методы Object
object obj = new();
obj.ToString();
obj.Equals(person);
obj.GetHashCode();
obj.GetType();

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    { 
        Company = company;
    }
}

class Company
{
    public string? WebSite { get; set; }
}
