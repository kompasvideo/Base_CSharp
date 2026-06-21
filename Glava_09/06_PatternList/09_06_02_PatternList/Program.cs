List<int> numbers = new List<int> { 1, 2, 3 };
Console.WriteLine(GetNumber(numbers));  // 2

int GetNumber(List<int> values) => values switch
{
    [1,2,3,4,5] => 1,
    [1,2,3] => 2,
    [1,2] => 3,
    [] => 4,
    _ => 5
};