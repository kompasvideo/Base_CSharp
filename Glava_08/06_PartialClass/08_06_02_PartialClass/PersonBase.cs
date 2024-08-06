public partial class Person
{
    partial void Read();
    public void DoSomething()
    {
        Read();
    }
}