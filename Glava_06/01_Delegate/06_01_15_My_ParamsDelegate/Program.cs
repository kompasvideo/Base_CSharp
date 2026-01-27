DoOperation(5, 4, Add);
DoOperation(5, 4, Subtract);
DoOperation(5, 4, Multiply);

void DoOperation(int a, int b, Operation op)
{
    Console.WriteLine(op(a, b));
}

int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

delegate int Operation(int x, int y);