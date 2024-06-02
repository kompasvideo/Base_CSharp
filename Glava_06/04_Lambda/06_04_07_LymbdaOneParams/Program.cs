PrintHandle print = message => Console.WriteLine(message);
print("Hello");
print(" message");

delegate void PrintHandle(string message);
