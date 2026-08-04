using System.Collections;

Week week = new Week();
foreach (var item in week)
{
    Console.WriteLine(item);
}
class Week : IEnumerable
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
}

class WeekEnumerator :IEnumerator
{
    private string[] days;
    private int position = -1;
    public WeekEnumerator(string[] days) { this.days = days; }

    public object? Current
    {
        get
        {
            if (position == -1 || position >= days.Length)
                throw new ArgumentException();
            return days[position];
        }
    }
    public bool MoveNext()
    {
        if(position < days.Length - 1)
        {
            position++;
            return true;
        }
        return false;
    }

    public void Reset() => position = -1;
}