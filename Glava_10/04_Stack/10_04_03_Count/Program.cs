var people = new Stack<string>();
people.Push("Tom");
// people + {"Tom"}
people.Push("Sam");
// people + {"Tom", 'Sam"}
people.Push("Bob");
// people + {"Tom", "Sam", "Bob"}

if (people.Count > 0)
{
    var person = people.Peek();
    people.Pop();
    Console.WriteLine(person);
}