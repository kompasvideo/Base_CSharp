Console.WriteLine(GetNumber(new[] {1,2,3,4,5})); // 1
Console.WriteLine(GetNumber(new[] {1,2})); // 3
Console.WriteLine(GetNumber(new int[] {})); // 4
Console.WriteLine(GetNumber(new[] {1,2,5})); // 5

int GetNumber(int[] values) => values switch
{
   [1,2,3,4,5] => 1,
   [1,2,3] => 2,
   [1,2] => 3,
   [] => 4,
   _ => 5
};