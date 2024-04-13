//string name = "Bob";
string name = "Tom";
//string name = "Sam";
//string name = "Jon";

switch (name)
{
    case "Bob":
        Console.WriteLine("You name - Bob");
        break;
    case "Tom":
        Console.WriteLine("You name - Tom");
        goto case "Bill";
    case "Sam":
        Console.WriteLine("You name - Sam");
        return;
    case "Jon":
        Console.WriteLine("You name - Jon");
        throw new Exception();
    case "Bill":
        Console.WriteLine("You name - Bill");
        break;
    default:
        Console.WriteLine("You unknown name");
        break;
}
int result = DoOperation(1, 10, 5);
Console.WriteLine(result);
int result2 = DoOperation2(1, 10, 5);
Console.WriteLine(result2);

int DoOperation(int op, int a, int b)
{
    switch(op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}

int DoOperation2(int op, int a, int b)
{
    return op switch 
    { 
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => a + b,
    };
}

int DoOperation3(int op, int a, int b) => op switch
{
    1 => a + b,
    2 => a - b,
    3 => a * b,
    _ => a + b,
};