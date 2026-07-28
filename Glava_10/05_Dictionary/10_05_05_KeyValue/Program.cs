var people = new Dictionary<int, string>()
{
    [5] = "Tom",
    [6] = "Bob",
    [7] = "Sam",
};
foreach (var (key, value) in people)
    Console.WriteLine($"key = {key}, value = {value}");