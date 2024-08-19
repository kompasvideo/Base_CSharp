var person = new Person("Tom", 37);
person.Name = "Bob";
Console.WriteLine(person.Name);

// структура record доступна для чтения
public readonly record struct Person(string Name, int Age);