Queue<string> people = new Queue<string>();
Console.WriteLine(people.Capacity);

Queue<string> people2 = new Queue<string>(16);
Console.WriteLine(people2.Capacity);

var employees = new List<string>{"Tom", "Sam", "Bob"};
Queue<string> people3 = new Queue<string>(employees);
foreach (var person in people) Console.WriteLine(person);

Console.WriteLine(people3.Count);