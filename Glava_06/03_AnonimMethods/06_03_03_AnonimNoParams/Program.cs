MessageHandler handler = delegate
{
    Console.WriteLine("анонимный метод");
};
handler("Hello world!");

delegate void MessageHandler(string message);