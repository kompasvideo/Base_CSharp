Operation<decimal, int> squareOperation = Square;
decimal result = Square(5);
Console.WriteLine(result);

Operation<int, int> doubleOperation = Double;
int result2 = Double(5);
Console.WriteLine(result2);

decimal Square(int n) => n * n;
int Double(int n) => n + n;

delegate T Operation<T, K>(K val);