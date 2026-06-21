Console.WriteLine(GetNumber(new[] {2,3,5}));    // 1
Console.WriteLine(GetNumber(new[] {2,4,6}));    // 2
Console.WriteLine(GetNumber(new[] {1,2,5}));    // 3
Console.WriteLine(GetNumber(new[] {1,2,3}));    // 4
Console.WriteLine(GetNumber(new int[] {}));    // 5

int GetNumber(int[] values) => values switch
{
    [2, _, 5] => 1,
    [2, _, _] => 2,
    [_, _, 5] => 3,
    [_,_,_] => 4,
    _ => 5
};