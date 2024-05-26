Operation<decimal, int> squareOperation = Square;
decimal result = squareOperation(5);
Console.WriteLine(result); // 25

Operation<int, int> doubleOperation = Double;
int result2 = doubleOperation(5);
Console.WriteLine(result2); // 10

decimal Square(int n) => n * n;
int Double(int n) => n + n;

delegate T Operation<T, K>(K val);