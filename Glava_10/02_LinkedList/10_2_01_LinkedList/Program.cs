var employee = new List<string> { "Tom", "Sam", "Bob" };

LinkedList<string> people = new LinkedList<string>(employee);
foreach (var person in people)
{
    Console.WriteLine(person);
}
