var person = new Person("Tom", 37);
person.Name = "Bob";

public record Person(string Name, int Age);