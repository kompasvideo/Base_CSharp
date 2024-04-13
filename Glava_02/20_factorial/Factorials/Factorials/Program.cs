int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}

int factorial4 = Factorial(4);
int factorial5 = Factorial(5);
int factorial6 = Factorial(6);
Console.WriteLine($"факториал числа 4 = {factorial4}");
Console.WriteLine($"факториал числа 5 = {factorial5}");
Console.WriteLine($"факториал числа 6 = {factorial6}");