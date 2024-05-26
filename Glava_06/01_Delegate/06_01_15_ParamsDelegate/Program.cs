DoOperation(5, 4, Add);         // 9
DoOperation(5, 4, Subtract);    // 1
DoOperation(5,4, Multiply);     // 20

void DoOperation(int x, int y, Operation op)
{
    Console.WriteLine(op(x,y));
}
int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

delegate int Operation(int x, int y);