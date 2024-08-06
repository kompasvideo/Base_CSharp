var tuple = GetValues();
Console.WriteLine(tuple.Item1);     // 1
Console.WriteLine(tuple.Item2);     // 3

(int, int) GetValues()
{
    var result = (1, 3);
    return result;
}