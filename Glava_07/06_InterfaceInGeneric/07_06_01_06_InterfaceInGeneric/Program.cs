// создаём мессенджер
var telegram = new Messenger<Message>();
// создаём сообщение
var message = new Message("Hello World!");
// отправляем сообщение
telegram.Send(message);

var telegram2 = new Messenger<PrintableMessage>();
var message2 = new PrintableMessage("Hello World");
telegram2.Send(message2);

interface IMessage
{
    string Text { get; } // Текст сообщения
}
interface IPrintable
{
    void Print();
}
class Message: IMessage, IPrintable
{
    public string Text { get; }
    public Message(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}
class Messenger<T> where T : IMessage, IPrintable
{
    public void Send(T message)
    {
        Console.WriteLine("Отправка сообщения");
        message.Print();
    }
}

interface IPrintableMessage : IMessage, IPrintable { }
class PrintableMessage : IPrintableMessage
{
    public string Text { get; }
    public PrintableMessage(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}