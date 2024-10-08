﻿var person = new Person("Tom");
person.Name = "Bob";
Console.WriteLine(person.Name);

public record Person
{
    public string Name { get; init; }
    public Person(string name) => Name = name;
}
public record class Person2
{
    public string Name { get; set; }
    public Person2(string name) => Name = name;
}
public record struct Person3
{
    public string Name { get; set; }
    public Person3(string name) => Name = name;
}

