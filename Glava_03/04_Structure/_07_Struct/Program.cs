namespace _07_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Tom = new Person { name = "Tom", age = 22 };
            Tom.Print();
        }
    }

    struct Person
    {
        public string name;
        public int age;
        public void Print() => Console.WriteLine($"Name: {name}, age: {age}");
    }
}
