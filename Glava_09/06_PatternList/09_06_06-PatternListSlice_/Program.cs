Console.WriteLine(GetNumber(new[] {1,2,3,4}));  // 1
Console.WriteLine(GetNumber(new[] {1,2,3}));  // 1
Console.WriteLine(GetNumber(new[] {1,2}));  // 1
Console.WriteLine(GetNumber(new[] {1}));  // 2
Console.WriteLine(GetNumber(new[] {1}));  // 2

int GetNumber(int[] values) => values switch
{
    [_, .., _] => 1,
    [..]  => 2
};