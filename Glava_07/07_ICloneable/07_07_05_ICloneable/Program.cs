var tom = new Person("Tom", 23, new Company("Microsoft"));
var bob = (Person)tom.Clone();
bob.Work.Name = "Google";
Console.WriteLine(tom.Work.Name);  // Microsoft

class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Company Work { get; set; }
    public Person(string name, int age, Company company)
    {
        Name = name;
        Age = age;
        Work = company;
    }
    public object Clone() => new Person(Name, Age, new Company(Work.Name));
}

class Company
{
    public string Name { get; set; }
    public Company(string name) => Name = name;
}