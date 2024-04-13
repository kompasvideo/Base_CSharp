namespace _08_Struct_With
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { name ="Tom", age = 21 };
            Person bob = tom with { name = "Bob" };
            bob.Print();
        }
    }

    struct Person
    {
        public string name; 
        public int age;
        public void Print() => Console.WriteLine($"Name: {name}, age: {age}");
    }
}
