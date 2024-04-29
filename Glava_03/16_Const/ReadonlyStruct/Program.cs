namespace ReadonlyStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    readonly struct Person
    {
        public readonly string name;
        public readonly int Age { get; }
        public Person(string name, int age) 
        {
            this.name = name;
            Age = age;
        }
    }
}
