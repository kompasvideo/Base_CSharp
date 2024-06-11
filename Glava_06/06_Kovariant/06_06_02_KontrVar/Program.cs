// делегату с производным типом передадим метод с базовым типом
EmailReciever emailBox = ReceiveMessage; // контрвариантность
emailBox(new EmailMessage("Welcome"));  // Email: Welcome
void ReceiveMessage(Message message) => message.Print();

delegate void EmailReciever(EmailMessage message);

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