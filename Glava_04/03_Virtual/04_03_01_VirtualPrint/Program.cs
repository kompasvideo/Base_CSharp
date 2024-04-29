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
    int age = 1;
    public virtual int Age
    {
        get => age;
        set { if (value > 0 && value < 100) age = value; }
    }
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    public virtual void Print() => Console.WriteLine(Name);    
}

class Employee : Person
{
    public override int Age
    {
        get => base.Age;
        set { if (value > 17 && value < 100) base.Age = value; }
    }
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
        base.Age = 18;
    }
    public override sealed void Print()
    {
        //Console.WriteLine($"{Name} работает в {Company}");
        base.Print();
        Console.WriteLine($" работает в {Company}");
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