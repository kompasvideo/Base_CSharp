var person = new Person("Tom", 37);
Console.WriteLine(person);      // Person {Name = Tom, Age = 37}

public record Person(string Name, int Age);