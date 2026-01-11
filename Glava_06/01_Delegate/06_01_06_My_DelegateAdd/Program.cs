Message message = Hello;
message += HowAreYou;

message();

void Hello() => Console.WriteLine("Hello, World!");
void HowAreYou() => Console.WriteLine("How are you");

delegate void Message();