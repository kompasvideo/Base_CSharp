﻿try
{
    try
    {

        Console.Write("Введите имя: ");
        string? name = Console.ReadLine();
        if (name == null || name.Length < 2)
        {
            throw new Exception("Длина имени меньше 2 символов");
        }
        else
        {
            Console.WriteLine($"Ваше имя: {name}");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ошибка: {e.Message}");
        throw;
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}