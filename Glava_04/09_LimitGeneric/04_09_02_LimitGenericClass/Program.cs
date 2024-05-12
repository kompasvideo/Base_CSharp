Messager<Message> telegram = new Messager<Message>();
telegram.SendMessage(new Message("Hello World!"));

Messager<EmailMessage> outlook = new Messager<EmailMessage>();
outlook.SendMessage(new EmailMessage("Bye World"));

class Messager<T> where T: Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Выводим сообщение {message.Text}");
    }
}

class Message
{
    public string Text { get; }

    public Message(string text)
    {
        Text = text;
    }
}

class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}