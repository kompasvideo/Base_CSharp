Message? message = Hello;
message += HowAreYou;
message();
Console.WriteLine();
message -= HowAreYou;
if (message != null)
    message();

void Hello() => Console.WriteLine("Hello");
void HowAreYou() => Console.WriteLine("How are you");
delegate void Message();