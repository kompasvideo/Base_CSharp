var people = new Dictionary<int, string>()
{
    [5] ="Tom",
    [6] = "Sam",
    [7] = "Bob"
};
foreach (var person in people)
    Console.WriteLine($"key = {person.Key}, value = {person.Value}");