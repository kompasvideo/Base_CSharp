var tom = new Person("Tom", 37);
var bob = new Employee("Bob", 41, "Microsoft");
Console.WriteLine(tom);     // Person { Name = Tom, Age = 37 }
Console.WriteLine(bob);     // Employee { Name = Bob, Age = 41, Company = Microsoft }

public record Person(string Name, int Age);
public record Employee(string Name, int Age, string Company) : Person(Name, Age);