Person tom = new Person { name = "Tom", company = { title = "Microsoft" } };

class Person
{
    public string name;
    public Company company;
    public Person()
    {
        name = "Undefened";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name} Компания: {company.title}");
}
class Company
{
    public string title = "Unknown";
}