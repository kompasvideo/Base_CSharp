Operation operation = SelectOperation(OperationType.Add);
Console.WriteLine(operation(10,4));                 // 14

operation = SelectOperation(OperationType.Subtract);
Console.WriteLine(operation(10, 4));                // 6

operation = SelectOperation(OperationType.Multiply);
Console.WriteLine(operation(10, 4));                // 40
int? res = operation?(10, 4);

Operation SelectOperation(OperationType opType)
{
    switch(opType)
    {
        case OperationType.Add: return (x, y) => x + y;
        case OperationType.Subtract: return (x, y) => x - y;
        default: return (x, y) => x * y;
    }
}
enum OperationType
{
    Add, Subtract, Multiply
}
delegate int Operation(int x, int y);