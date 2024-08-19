namespace _08_09_01_RecordsCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Tom");
            var person2 = new Person("Tom");
            Console.WriteLine(person1.Equals(person2)); // true

            var user1 = new User("Tom");
            var user2 = new User("Tom");
            Console.WriteLine(user1.Equals(user2));     // false

            Console.WriteLine(person1 == person2);      // true
            Console.WriteLine(user1 == user2);          // false
        }
    }
    public record Person
    {
        public string Name { get; init; }
        public Person(string name) => Name = name;
    }
    public class User
    {
        public string Name { get; init; }
        public User(string name) => Name = name;
    }
}
