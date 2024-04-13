namespace Constructor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new ();
            Person bob = new ("Bob");
            Person sam = new ("Sam", 25);
            //Person sam = new Person
            //{
            //    name = "Sam",
            //    age = 18
            //};
            tom.Print();
            bob.Print();
            sam.Print();
        }
    }

    //class Person
    //{
    //    public string name;
    //    public int age;
    //    //public Person() : this("Неизвестно")  {  }
    //    //public Person(string name) : this(name , 18) { }
    //    //public Person(string name, int age) { this.name = name; this.age = age; }
    //    public Person(string name = "Неизвестно", int age = 18) { this.name = name; this.age = age; }
    //    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
        
    //}

    public class Person(string name = "Неизвестно", int age = 18)
    {
        public Person(string name) : this (name, 18) { }
        public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}
