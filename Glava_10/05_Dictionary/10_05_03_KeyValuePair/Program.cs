var mike = new KeyValuePair<int, string>(56, "Mike");
var employees = new List<KeyValuePair<int, string>>() { mike };
var people = new Dictionary<int, string>(employees)
{
    [5] = "Tom",
    [6] = "Sam",
    [7] = "Bob"
};
Console.WriteLine(people[5]);