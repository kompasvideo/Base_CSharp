Messenger<Message, Person> telegram = new Messenger<Message, Person>();
Person tom = new Person("Tom");
Person bob = new Person("Bob");
Message hello = new Message("Hello World!");
telegram.SendMessage(tom, bob, hello);

class Messenger<T,P> where T: Message where P: Person
{
    public void SendMessage(P sender, P receiver, T message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Message
{
    public string Text { get; }
    public Message(string text) => Text = text;
}