MessageHandler handler = delegate (string mes)
{
    Console.WriteLine(mes);
};
handler("hello world");

delegate void MessageHandler(string message);