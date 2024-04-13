namespace DefaultStruct;
class Program
{
    static void Main(string[] args)
    {
        Person tom = new Person();
        tom.Print();
    }
}

struct Person
{
    public string name ="Tom";
    public int age = 1;

    public Person() { }
    public void Print() => Console.WriteLine($"Name: {name}, Age: {age}");
}