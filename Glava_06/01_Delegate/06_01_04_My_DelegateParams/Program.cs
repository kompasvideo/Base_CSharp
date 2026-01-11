Operation operation = Add;
int result = operation(5, 4);
Console.WriteLine(result);

operation = Multiply;
result = operation(6, 8);
Console.WriteLine(result);

int Add(int x, int y) => x + y;
int Multiply(int x, int y) => x * y;
delegate int Operation(int x, int y);