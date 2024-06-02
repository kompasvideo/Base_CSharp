var hello = () => Console.WriteLine("METANIT.COM");

var message = () => Console.WriteLine("Hello ");
message += () => Console.WriteLine("World!");
message += hello;
message += Print;

message();
Console.WriteLine("----------------");

message -= Print;
message -= hello;
message?.Invoke();

void Print() => Console.WriteLine("Welcome to C#");
