int x = 1;
int y = 0;
try
{
    int result1 = x / y;
    int result2 = y / x;
}
catch (DivideByZeroException ex) when (y == 0)
{
    Console.WriteLine("y не должно быть рвно 0");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}