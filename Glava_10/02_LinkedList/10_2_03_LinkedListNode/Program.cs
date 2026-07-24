LinkedList<string> people = new LinkedList<string>(new[] {"Tom", "Sam", "Bob"});

// от начала до конца списка
var currentNode = people.First;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next;
}

Console.WriteLine();

// с конца до начала списка
currentNode = people.Last;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Previous;
}
