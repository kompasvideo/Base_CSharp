try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат {y}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Вызвано исключение");
}