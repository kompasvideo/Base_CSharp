SendMessage(new Message("Hello World"));
SendMessage(new EmailMessage("Bye World!"));

void SendMessage<T>(T message) where T: Message
{
    Console.WriteLine($"Отправляем сообщение {message.Text}");
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