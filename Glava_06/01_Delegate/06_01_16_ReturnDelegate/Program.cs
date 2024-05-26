Operation operation = SelectOperation(OperationType.Add);
Console.WriteLine(operation(10,4));

Operation operation2 = SelectOperation(OperationType.Subtract);
Console.WriteLine(operation2(10,4));

Operation operation3 = SelectOperation(OperationType.Multiply);
Console.WriteLine(operation3(10,4));

Operation SelectOperation(OperationType opType)
{
    switch(opType)
    {
        case OperationType.Add: return Add;
        case OperationType.Subtract: return Subtract;
        default: return Multiply;
    }
}

int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

enum OperationType
{
    Add, Subtract, Multiply
}
delegate int Operation(int x, int y);