namespace _05_Struct;

class Program
{
    static void Main(string[] args)
    {
        Person tom = new();
        Person bob = new("Bob");
        Person sam = new("Sam", 25);
        tom.Print();
        bob.Print();
        sam.Print();
    }
}

struct Person
{
    public string name;
    public int age;

    public Person() : this("Tom")
    {
    }

    public Person(string name) : this(name, 1)
    {
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print() => Console.WriteLine($" Name: {name}, Age: {age}");
}