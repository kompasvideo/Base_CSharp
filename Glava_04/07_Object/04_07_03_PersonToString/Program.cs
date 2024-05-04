Person tom = new Person { Name = "Tom" };
Console.WriteLine(tom.ToString());  // Tom

Person undeffined = new Person();
Console.WriteLine(undeffined.ToString());  // Person

class Person
{
    public string Name { get; set; } = "";
    public override string ToString()
    {
        if (string.IsNullOrEmpty(Name))
            return base.ToString();
        return Name;
    }
}
