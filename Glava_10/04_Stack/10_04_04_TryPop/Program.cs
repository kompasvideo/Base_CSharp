var people = new Stack<string>();
people.Push("Tom");
// people = {"Tom"}

var success1 = people.TryPop(out var person1);    // success1 = true
Console.WriteLine(person1);

var success2 = people.TryPop(out var person2);    // success2 = false
Console.WriteLine(person2);