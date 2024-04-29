using static System.Console;
using static Operation;

WriteLine("Hello, World!");

WriteLine(Sum(5, 4));       // 9
WriteLine(Subtract(5, 4));  // 1
WriteLine(Multiply(5, 4));  // 20

static class Operation
{
    public static int Sum(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}