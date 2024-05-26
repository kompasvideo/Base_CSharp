MessageHandler handler = delegate (string mes)
{
    Console.WriteLine(mes);
};
handler("Hello world!");

delegate void MessageHandler(string message);