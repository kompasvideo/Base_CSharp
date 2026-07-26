var mike = new KeyValuePair<int, string>(56, "Mike");
var employees = new List<KeyValuePair<int, string>>(){mike};
var people = new Dictionary<int, string>(employees);
Console.WriteLine(people.Capacity);
Console.WriteLine(people.Count);
Console.WriteLine(people[56]);