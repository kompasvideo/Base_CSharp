// Все объекты Message являются объектами Imessage
IMessage hello = new Message("Hello METANIT.COM");
Console.WriteLine(hello.Text);  // Hello METANIT.COM

// Не все объекты IMessage являются объектами Message, необходимо явное приведение
// Message someMessage = hello; // ! Ошибка

// Интерфейс IMessage не имеет свойства Print, необходимо явное приведение
// hello.Print(); // ! Ошибка

// если hello представляет класс Message, выполняем преобразование
if (hello is Message someMessage) someMessage.Print();

interface IMessage
{
    string Text { get; set; }
}
interface IPrintable
{
    void Print();
}
class Message : IMessage, IPrintable
{
    public string Text { get; set; }
    public Message(string text) => Text = text;    
    public void Print() => Console.WriteLine(Text);    
}