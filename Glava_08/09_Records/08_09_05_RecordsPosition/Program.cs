var person = new Person("Tom", 37);
var (personName, personAge) = person;
Console.WriteLine(personName);      // Tom
Console.WriteLine(personAge);       // 37


public record Person(string Name, int Age);