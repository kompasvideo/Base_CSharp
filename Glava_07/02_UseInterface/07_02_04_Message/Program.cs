Console.WriteLine("Hello, World!");

interface IMessage
{
    string Text { get; set; }
}

interface IPrintable
{
    void Print();
}

class Message : IMessage, IPrintable
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}