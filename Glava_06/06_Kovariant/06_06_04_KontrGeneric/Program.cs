// принимает объект более общего типа
MessageReceiver<Message> messageReceiver = (Message messsage) => messsage.Print();
// принимает объект более конкретного типа
MessageReceiver<EmailMessage> emailMessageReceiver = messageReceiver; // контрвариантность

messageReceiver(new Message("Hello world"));        // Message: Hello world
messageReceiver(new EmailMessage("Hello world"));   // Email: Hello world

delegate void MessageReceiver <in T > (T message);

class Message
{
    public string Text { get; }
    public Message(string text) => Text = text;
    public virtual void Print() => Console.WriteLine($"Message: {Text}");
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Email:{Text}");
}
class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Sms: {Text}");
}