var person = new Person("Tom", 37) { Company = "Google" };
Console.WriteLine(person.Company);          // Google
person.Company = "Microsoft";
Console.WriteLine(person.Company);          // Microsoft

public record Person(string Name, int Age)
{
    public string Company { get; set; } = "";
}