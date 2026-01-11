Message mes1 = Hello;
mes1.Invoke();
Operation operation = Add;
int n = operation.Invoke(3, 4);
Console.WriteLine(n);

void Hello() => Console.WriteLine("Hello, World!");
int Add(int x, int y) => x + y;

delegate int Operation(int x, int y);
delegate void Message();