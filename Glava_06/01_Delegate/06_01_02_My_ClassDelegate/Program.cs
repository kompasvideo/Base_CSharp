Message message1 = Welcome.Print;
Message message2 = new Hello().Display;
message1();
message2();

delegate void Message();

static class Welcome
{
    public static void Print() => Console.WriteLine("Welcome Print");
}

class Hello
{
    public Hello() { }
    public void Display() => Console.WriteLine("Hello Display");
}