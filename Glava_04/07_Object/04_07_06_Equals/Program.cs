var person1 = new Person { Name = "Tom" };
var person2 = new Person { Name = "Bob" };
var person3 = new Person { Name = "Tom" };

bool person1EqualsPerson2 = person1.Equals(person2); // false
bool person1EqualsPerson3 = person1.Equals(person3); // true

Console.WriteLine(person1EqualsPerson2); // false
Console.WriteLine(person1EqualsPerson3); // true


class Person
{
    public string Name { get; set; } = "";
    public override bool Equals(object? obj)
    {
        if (obj is Person person) return Name == person.Name;
        return false;
    }
    public override int GetHashCode() => Name.GetHashCode();    
}