Console.WriteLine(GetData(new[] { 2, 3, 4, 5 })); // Middle: 3, 4
Console.WriteLine(GetData(new[] { 2, 4, 6, 8})); // End: 4, 6, 8
Console.WriteLine(GetData(new[] { 1, 2, 3, 5 })); // Start: 1,2,3
Console.WriteLine(GetData(new[] { 1, 2, 3, 4})); // All: 1,2,3, 4
Console.WriteLine(GetData(new int[] { })); // All:

string GetData(int[] values) => values switch
{
    [2, .. var middle, 5] => $"Middle: {string.Join(",", middle)}",
    [2, .. var end] => $"End: {string.Join(",", end)}",
    [.., var start, 5] => $"Start: {string.Join(",", start)}",
    [.. var all] => $"All : {string.Join(",", all)}",
};
