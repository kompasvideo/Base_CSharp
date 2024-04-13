namespace StructEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.name = "Tom";
            tom.age = 37;
            tom.Print();
        }
    }

    struct Person
    {
        public string name;
        public int age;
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
            Print2();
        }
        void Print2()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
