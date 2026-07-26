var people = new Dictionary<int, string>()
{
    { 5, "Tom" },
    { 3, "Sam" },
    { 11, "Bob" }
};

var people2 = new Dictionary<int, string>()
{
    [5] = "Tom",
    [3] = "Sam",
    [11] = "Bob"
};

Console.WriteLine("Hello, World!");