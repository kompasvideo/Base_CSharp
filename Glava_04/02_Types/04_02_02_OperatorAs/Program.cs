Person person = new Person("Tom");
Employee? employee = person as Employee;
if (employee == null)
{
    Console.WriteLine("Преобразование прошло неудачно");
}
else
{
    Console.WriteLine(employee.Company);
}


if (person is Employee employee2)
{
    Console.WriteLine(employee2.Company);
}
else
{
    Console.WriteLine("Преобразование прошло неудачно");
}



if (person is Employee)
{
    Console.WriteLine("Преобразование прошло удачно");
}
else
{
    Console.WriteLine("Преобразование прошло неудачно");
}


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