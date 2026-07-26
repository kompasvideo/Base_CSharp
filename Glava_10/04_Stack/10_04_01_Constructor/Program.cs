Stack<string> people = new Stack<string>();
Console.WriteLine(people.Capacity);
    
Stack<string> people2 = new Stack<string>(16);
Console.WriteLine(people2.Capacity);    

var emloyees = new List<string>(){"Tom", "Bob", "Sam"};
Stack<string> people3 = new Stack<string>(emloyees);
foreach (var person in people3) Console.WriteLine(person);

Console.WriteLine(people3.Count); // 3
