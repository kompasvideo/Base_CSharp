// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

interface IMovable
{
    public const int minSpeed = 0;
    private static int maxSpeed = 60;
    public void Move();
    protected internal string Name { get; set; }
    public delegate void MoveHandler(string message);
    public event MoveHandler MoveEvent;
}