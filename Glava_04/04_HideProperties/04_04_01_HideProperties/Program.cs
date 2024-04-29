Person bob = new Person("Bob");
bob.Print();

Employee tom = new Employee("Tom", "Microsoft");
tom.Print();


// методы Object
Person personObj = new Person("Tom");
object obj = new();
obj.ToString();
obj.Equals(personObj);
obj.GetHashCode();
obj.GetType();

class Person
{
    public readonly static int minAge = 1;
    public const string typeName = "Person";
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Name {Name}");
    }
}

class Employee : Person
{
    public new readonly static int minAge = 18;
    public new const string typeName = "Employee";
    public new string Name 
    { 
        get => $"Mr./Ms. {base.Name}";
        set => base.Name = value;
    }
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
    public new void Print()
    {
        //Console.WriteLine($"Name: {Name}  Company {Company}");
        base.Print();
        Console.WriteLine($"  Company {Company}");
    }
}

class Company
{
    public string? WebSite { get; set; }
}

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}