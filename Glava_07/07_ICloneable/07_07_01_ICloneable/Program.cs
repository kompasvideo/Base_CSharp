var tom = new Person("Tom", 33);
var bob = tom;
bob.Name = "Bob";
Console.WriteLine(tom.Name); // Bob

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}