Message mes;
mes = Hello;
mes();

void Hello() => Console.WriteLine("Hello, World!");

delegate void Message();