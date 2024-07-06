// public delegate void Action()
// public delegate void Action<in T>(T obj)

DoOperation(10, 6, Add);        // 10 + 6 = 16 
DoOperation(10, 6, Multiply);   // 10 * 6 = 60

void DoOperation(int a, int b, Action<int, int> op)  => op(a, b);
void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");