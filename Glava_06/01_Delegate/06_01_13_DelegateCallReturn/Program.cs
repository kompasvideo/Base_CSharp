Operation op = Subtract;
op += Multiply;
op += Add;
Console.WriteLine(op(7,2));  // Add(7,2)

int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

delegate int Operation(int x, int y);