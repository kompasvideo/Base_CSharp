Counter counter1 = new Counter { Value = 23 };
Counter counter2 = new Counter { Value = 45 };

bool result = counter1 > counter2;
Console.WriteLine(result); // false

Counter counter3 = counter1 + counter2;
Console.WriteLine(counter3.Value); // 23 + 45 = 68

int result2 = counter1 + 27;
Console.WriteLine(result2); // 50

Console.WriteLine("operator ++");
Counter counter4 = new Counter() { Value = 10 };
Counter counter5 = counter4++;
Console.WriteLine(counter4.Value); // 20
Console.WriteLine(counter5.Value); // 10

Counter counter6 = ++counter4;
Console.WriteLine(counter4.Value); // 30
Console.WriteLine(counter6.Value); // 30

Console.WriteLine("operators true and false");
Counter counter = new Counter() { Value = 0 };
if (counter)
    Console.WriteLine(true);
else 
    Console.WriteLine(false);

Console.WriteLine("operator !");
Counter counter7 = new Counter() { Value = 2 };
if (!counter)
    Console.WriteLine(true);
else
    Console.WriteLine(false);

class Counter
{
    public int Value { get; set; }
    public static Counter operator +(Counter counter1, Counter counter2)
    {
        return new Counter { Value = counter1.Value + counter2.Value };
    }
    public static int operator +(Counter counter, int val)
    {
        return counter.Value + val;
    }
    public static bool operator >(Counter counter1, Counter counter2)
    {
        return counter1.Value > counter2.Value;
    }
    public static bool operator <(Counter counter1, Counter counter2)
    {
        return counter1.Value < counter2.Value;
    }    
    public static Counter operator ++(Counter counter1)
    {
        return new Counter { Value = counter1.Value + 10};
    }
    public static bool operator true(Counter counter1)
    {
        return counter1.Value != 0;
    }
    public static bool operator false(Counter counter1)
    {
        return counter1.Value == 0;
    }
    public static bool operator !(Counter counter1)
    {
        return counter1.Value == 0;
    }
}
