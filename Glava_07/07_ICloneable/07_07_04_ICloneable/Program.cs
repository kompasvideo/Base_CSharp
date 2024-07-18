﻿var tom = new Person("Tom", 23, new Company("Microsoft"));
var bob = (Person)tom.Clone();
bob.Work.Name = "Google";
Console.WriteLine(tom.Work.Name);  // Google

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
    public object Clone() => MemberwiseClone();    
}

class Company
{
    public string Name { get; set; }
    public Company(string name) => Name = name;
}