Operation op = Subtract;
op += Multiply;
op += Add;
Console.WriteLine(op(7,2));

int Add(int x, int y)
{
    Console.WriteLine("Add");
    return x + y;
}

int Subtract(int x, int y)
{
    Console.WriteLine("Subtract");
    return x - y;
}

int Multiply(int x, int y) 
{
    Console.WriteLine("Multiply");
    return x * y; 
}

delegate int Operation(int x, int y);