int x = 7;
int y = 25;
Swap<int>(ref x, ref y);
Console.WriteLine($"x={x}, y={y}"); // x =25  y = 7

string x1 = "hello";
string y1 = "bye";
Swap<string>(ref x1, ref y1);
Console.WriteLine($"x1={x1}, y1={y1}");  //  x1= bye, y1=hello

void Swap<T>(ref T x, ref T y)
{
    T temp = x;
    x = y;
    y = temp;
}