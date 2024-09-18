var microsoft = new Company("Microsoft");
var google = new Company("Google");
var tom = new Employee("Tom", microsoft);
var bob = new Employee("Bob", google);

PrintCompany(tom);
PrintCompany(bob);

void PrintCompany(Employee employee)
{
    //if (employee is Employee { Company: { Title: "Microsoft"} })
    if (employee is Employee { Company.Title: "Microsoft"} )
    {
        Console.WriteLine($"{employee.Name} works in Microsoft");
    }
    else
    {
        Console.WriteLine($"{employee.Name} works someware");
    }
}

class Employee
{
    public string Name { get; }
    public Company Company { get; set; }
    public Employee(string name, Company company)
    {
        Name = name;
        Company = company;
    }
}
class Company
{
    public string Title { get; }
    public Company(string title) => Title = title;
}