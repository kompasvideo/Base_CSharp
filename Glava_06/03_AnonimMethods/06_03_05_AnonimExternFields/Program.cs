int z = 8;
Operation operation = delegate (int x, int y)
{
    return x + y + z;
};
int result = operation(4, 5);
Console.WriteLine(result);

delegate int Operation(int x, int y);