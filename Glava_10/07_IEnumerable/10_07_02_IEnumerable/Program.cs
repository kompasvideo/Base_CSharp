using System.Collections;

Week week = new Week();
foreach (var item in week)
{
    Console.WriteLine(item);
}

class Week : IEnumerable
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    public IEnumerator GetEnumerator() => days.GetEnumerator();
}
