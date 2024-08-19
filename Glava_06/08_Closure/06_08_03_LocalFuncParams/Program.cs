var fn = Multiply(5);
Console.WriteLine(fn(5));   // 25
Console.WriteLine(fn(6));   // 30
Console.WriteLine(fn(7));   // 35

Operation Multiply(int n)
{
    int Inner(int m)
    {
        return n * m;
    }
    return Inner;
}
delegate int Operation(int n);

