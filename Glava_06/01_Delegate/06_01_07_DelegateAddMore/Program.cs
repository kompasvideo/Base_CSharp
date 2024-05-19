Message message = Hello;
message += HowAreYou;
message += Hello;
message += Hello;
message();

void Hello() => Console.WriteLine("Hello");
void HowAreYou() => Console.WriteLine("How are you");

delegate void Message();
