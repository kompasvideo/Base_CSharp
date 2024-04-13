int Fibonachi2(int n)
{
    int result = 0;
    int b = 1;
    int tmp;

    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }

    return result;
}

int fib4 = Fibonachi2(4);
int fib5 = Fibonachi2(5);
int fib6 = Fibonachi2(6);

Console.WriteLine($"4 число Фибоначчи = {fib4}");
Console.WriteLine($"5 число Фибоначчи = {fib5}");
Console.WriteLine($"6 число Фибоначчи = {fib6}");