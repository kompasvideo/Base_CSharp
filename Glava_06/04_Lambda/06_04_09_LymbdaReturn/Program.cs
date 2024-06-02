var sum = (int x, int y) => x + y;
int sumResult = sum(4, 3);
Console.WriteLine(sumResult);

Operation multiply = (x,y) => x * y;
int multiplyResult = multiply(4, 5);
Console.WriteLine(multiplyResult);

delegate int Operation(int x, int y);
