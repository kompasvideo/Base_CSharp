namespace _03_Struct;

class Program
{
    static void Main(string[] args)
    {
       Person tom = new Person();
       Person bob = new Person("Bob");
       Person sam = new Person("Sam", 25);
       tom.Print();
       bob.Print();
       sam.Print();
    }
}


struct Person
{
    public string name;
    public int age;

    public Person(string name = "Tom", int age = 1)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Name: {name}, age: {age}");
}