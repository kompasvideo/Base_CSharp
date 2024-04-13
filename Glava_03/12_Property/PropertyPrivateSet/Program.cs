Person tom = new("Tom");
Console.WriteLine(tom.Name);

class Person
{
    string name = "";
    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public Person(string name) => Name = name;
}