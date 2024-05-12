﻿try
{
    int x = 5;
    int y = x / 0;
    Console.WriteLine($"Результат {y}");
}
catch(Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
    Console.WriteLine($"Метод: {ex.TargetSite}");
    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
}