Console.WriteLine(GetNumber(new[] {2, 5}));     // 1
Console.WriteLine(GetNumber(new[] {2, 3,4,5})); // 1

Console.WriteLine(GetNumber(new[] {2}));        // 2
Console.WriteLine(GetNumber(new[] {2, 3, 4}));  // 2

Console.WriteLine(GetNumber(new[] {3, 4, 5}));  // 3
Console.WriteLine(GetNumber(new[] {5}));        // 3

Console.WriteLine(GetNumber(new int[] {}));     // 4
Console.WriteLine(GetNumber(new[] {1}));        // 4
Console.WriteLine(GetNumber(new[] {1, 2, 3}));  // 4

int GetNumber(int[] values) => values switch
{
    [2, .., 5] => 1,        // если первый элемент -5, а последний -2
    [2, ..] => 2,           // если первый элемент -2
    [.., 5] => 3,           // если последний элемент -5
    [..] => 4               // произвольное количество элементов
};