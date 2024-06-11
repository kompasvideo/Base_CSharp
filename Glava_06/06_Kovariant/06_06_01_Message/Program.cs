// делегату с базовым типом передаём метод с производным типом
MessageBuilder messageBulder = WriteEmailMessage; // ковариантность
Message message = messageBulder("Hello");
message.Print();    // Email: Hello

EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);
delegate Message MessageBuilder(string text);

class Message
{
    public string Text { get; }
    public Message(string text) => Text = text;
    public virtual void Print() => Console.WriteLine($"Message: {Text}");
}
class EmailMessage : Message
{
    public EmailMessage( string text): base(text) { }
    public override void Print() => Console.WriteLine($"Email:{Text}");
}
class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) {}
    public override void Print() => Console.WriteLine($"Sms: {Text}");
}