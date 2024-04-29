// UpCasting
Employee employee = new Employee("Tom", "Microsoft");
Person person = employee;
Console.WriteLine(person.Name);

Person bob = new Client("Bob", "CosmosBank");

// DownCasting
Employee employee2 = new Employee("Bob", "Intel");
Person person2 = employee2;
Employee employee3 = (Employee)person2;
Console.WriteLine($"{employee3.Name}, {employee3.Company}");

object obj1 = new Employee("Bill", "Microsoft");
Employee employee1 = (Employee)obj1;


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
        Console.WriteLine($"Person {Name}");
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

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name) 
    {
        Bank = bank;
    }
}