IMessenger<EmailMessage> outlook = new SimpleMessenger();
outlook.SendMessage(new EmailMessage("Hi!"));

IMessenger<Message> telegram = new SimpleMessenger();
IMessenger<EmailMessage> emailClient = telegram;
emailClient.SendMessage(new EmailMessage("Hello"));

class Message
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}
interface IMessenger<in T>
{
    void SendMessage(T message);
}
class SimpleMessenger : IMessenger<Message>
{
    public void SendMessage(Message message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}