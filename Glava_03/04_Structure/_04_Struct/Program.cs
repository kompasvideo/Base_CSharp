namespace _04_Struct;

class Program
{
    static void Main(string[] args)
    {
        Person tom = new();
        tom.Print();
    }
}

struct Person
{
    public string name;
    public int age;

    public Person()
    {
        name = "Tom";
        age = 37;
    }
    public void Print() => Console.WriteLine($"Name: {name}, age:{age}");
}