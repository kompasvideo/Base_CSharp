var employee = new List<string> { "Tom", "Sam", "Bob" };

LinkedList<string> people = new LinkedList<string>(employee);
Console.WriteLine(people.Count);            // 3
Console.WriteLine(people.First?.Value);     // Tom
Console.WriteLine(people.Last?.Value);      // Bob
