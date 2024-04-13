namespace _06_Struct;

class Program
{
    static void Main(string[] args)
    {
        var tom = new Person("Tom", 38);
        tom.Print();
    }
}

struct Person(string name, int age)
{
    public Person(string name) : this(name, 18) { }
    public void Print() => Console.WriteLine($" Name: {name}, Age: {age}");
}