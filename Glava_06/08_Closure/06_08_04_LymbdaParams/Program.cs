var multiply = (int n) => (int m) => n * m;

var fn = multiply(5);

Console.WriteLine(fn(5));  // 25
Console.WriteLine(fn(6));  // 30
Console.WriteLine(fn(7));  // 35


