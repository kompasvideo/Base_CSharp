// Возвращяет EmailMessage - более конкретный тип
MessageBuilder<EmailMessage> EmailMessageWriter = (string text) =>new EmailMessage(text);
// возвращяет более общий тип Message
MessageBuilder<Message> messageBuilder = EmailMessageWriter;  // ковариантность 
Message message = messageBuilder("Hello Tom"); // вызов делегата
message.Print(); // Email: Hello Tom

delegate T MessageBuilder<out T>(string text);

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