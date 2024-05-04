Person tom = new Person { Name = "Tom" };
Console.WriteLine(tom.GetHashCode());
Person person = new Person { Name = "Tom2" };
Console.WriteLine(person.GetHashCode());
Person tom2 = new Person { Name = "Tom" };
Console.WriteLine(tom2.GetHashCode());


class Person
{
    public string Name { get; set; } = "";
    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
