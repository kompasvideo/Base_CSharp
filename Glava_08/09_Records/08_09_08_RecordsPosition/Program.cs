var person = new Person("Tom", 37);
person.Name = "Bob";
Console.WriteLine(person.Name);     // Bob
// структура record
public record struct Person(string Name, int Age);