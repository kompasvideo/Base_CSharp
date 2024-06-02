var subtract = (int x, int y) =>
{
    if (x > y) return x - y;
    else return y - x;
};
int result = subtract(10, 6);
Console.WriteLine(result);

int result2 = subtract(-10, 6);
Console.WriteLine(result2);