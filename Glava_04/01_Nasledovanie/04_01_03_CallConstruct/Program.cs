Employee employee = new Employee("Sam",22, "Microsoft");


class Person
{
    string name;
    int age;

    public Person(string name)
    {
        this.name = name;
        Console.WriteLine("Person (string name)");
    }
    public Person(string name, int age) : this(name)
    {
        this.age = age;
        Console.WriteLine("Person (string name, int age)");
    }
    public void Print()
    {
        Console.WriteLine(name);
    }
}

class Employee : Person
{
    string company;
    public Employee(string name, int age, string company) : base(name, age)
    {
        this.company = company;
        Console.WriteLine("Employee(string name, int age, string company)");
    }
}

class Company
{
    public string? WebSite { get; set; }
}
