try
{
    object obj = "you";
    int num = (int)obj;
    Console.WriteLine($"Результат {num}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("DivideByZeroException");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("IndexOutOfRangeException");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}