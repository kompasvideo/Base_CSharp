Person person = new Person { Name = "Tom" };
Console.WriteLine(person.ToString());

Clock clock = new Clock {  Hours = 15, Minutes = 24, Seconds = 53 };
Console.WriteLine(clock.ToString());

class Clock
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public override string ToString()
    {
        return $"{Hours}:{Minutes}:{Seconds}";
    }
}
class Person
{
    public string Name { get; set; } = "";
}