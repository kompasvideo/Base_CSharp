Counter counter1 = new Counter { Seconds = 23 };

int x = (int)counter1;
Console.WriteLine(x);                   // 23

Counter counter2 = x;
Console.WriteLine(counter2.Seconds);    // 23

class Counter
{
    public int Seconds { get; set; }
    public static implicit operator Counter(int x)
    {
        return new Counter { Seconds = x };
    }
    public static explicit operator int(Counter counter)
    {
        return counter.Seconds;
    }
}