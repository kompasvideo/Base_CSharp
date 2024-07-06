// TResult Func<out TResult>();

int result1 = DoOperation(6, DoubleNumber); // 12
Console.WriteLine(result1);

int result2 = DoOperation(6, SquareNumber); // 36
Console.WriteLine(result2);

int DoOperation(int n, Func<int, int> operation) => operation(n);
int DoubleNumber(int n) => 2 * n;
int SquareNumber(int n) => n * n;


Func<int, int, string> createString = (a, b) => $"{a}{b}";
Console.WriteLine(createString(1,5)); // 15
Console.WriteLine(createString(3,5)); // 35  