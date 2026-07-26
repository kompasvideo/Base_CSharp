var people = new Queue<string>();
people.Enqueue("Tom");
people.Enqueue("Bob");  
people.Enqueue("Sam");

if (people.Count > 0)
{
    var person = people.Peek();
    people.Dequeue();
    Console.WriteLine(person);
}