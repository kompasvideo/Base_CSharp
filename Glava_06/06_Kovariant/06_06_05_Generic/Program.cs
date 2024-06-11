MessageConverter<Message, EmailMessage> toEmailConverter = 
    (Message message) => new EmailMessage(message.Text);

MessageConverter<SmsMessage, Message> converter = toEmailConverter;
Message message = converter(new SmsMessage("Hello work"));
message.Print();    // Email: Hello work

delegate E MessageConverter<in M, out E>(M message); 

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