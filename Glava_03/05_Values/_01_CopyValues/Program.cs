State state1 = new State();
State state2 = new State();
state2.x = 1;
state2.y = 2;
state1 = state2;
state2.x = 5;
Console.WriteLine(state1.x); // 1
Console.WriteLine(state2.x); // 5

Country country1 = new Country();
Country country2 = new Country();
country2.x = 1;
country2.y = 4;
country1 = country2;
country2.x = 7;
Console.WriteLine(country1.x);  // 7
Console.WriteLine(country2.x);  // 7

struct State
{
    public int x;
    public int y;
    public Country country;
    public State()
    {
        x = 0;
        y = 0;
        country = new Country();
    }
}

class Country
{
    public int x;
    public int y;
}