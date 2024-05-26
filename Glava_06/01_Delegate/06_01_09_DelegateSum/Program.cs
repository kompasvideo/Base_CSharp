Message mes1 = Hello;
Message mes2 = HowAreYou;
Message mes3 = mes1 + mes2;
mes3();

void Hello() => Console.WriteLine("Hello");
void HowAreYou() => Console.WriteLine("How are you");
delegate void Message();