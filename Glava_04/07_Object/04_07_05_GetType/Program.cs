Person person = new Person { Name = "Tom" };
Console.WriteLine(person.GetType()); // Person

object person2 = new Person { Name = "Tom" };
if (person2.GetType()  == typeof(Person))
    Console.WriteLine("Это реально класс Person");

if (person2 is Person )
    Console.WriteLine("Это реально класс Person");
person2.GetHashCode();

class Person
{
    public string Name { get; set; } = "";
    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
