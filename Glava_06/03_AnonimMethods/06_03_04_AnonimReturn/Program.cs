Operation operation = delegate (int x, int y)
{
    return x + y;
};
int result = operation(4, 5);
Console.WriteLine(result);


delegate int Operation(int x, int y);