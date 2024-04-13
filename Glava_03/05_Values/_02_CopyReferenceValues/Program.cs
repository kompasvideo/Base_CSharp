State state1 = new State();
State state2 = new State();

state2.country.x = 5;
state1 = state2;
state2.country.x = 8;
Console.WriteLine(state1.country.x); // 8
Console.WriteLine(state2.country.x); // 8

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