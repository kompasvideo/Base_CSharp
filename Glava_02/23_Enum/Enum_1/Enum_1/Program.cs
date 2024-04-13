namespace Enum_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DayTime dayTime = DayTime.Morning;
            if (dayTime == DayTime.Morning)
                Console.WriteLine("Доброе утро");
            else
                Console.WriteLine("Привет");
        }
    }

    enum DayTime
    {
        Morning = 3,
        Afternoon = Morning,
        Evening = 4,
        Night = 2
    }

    enum Time : byte
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }
}
