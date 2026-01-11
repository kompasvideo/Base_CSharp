Operation<decimal, int> squareOperation = Square;
decimal result1 = squareOperation(5);
Console.WriteLine(result1);

Operation<int, int> doubleOperation = Double;
int result2 = doubleOperation(5);
Console.WriteLine(result2);

decimal Square(int n) => n * n;
int Double(int n) => n + n;

delegate T Operation<T, K>(K val);