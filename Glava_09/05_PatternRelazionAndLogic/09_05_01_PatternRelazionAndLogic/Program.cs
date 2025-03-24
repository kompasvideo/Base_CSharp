Console.WriteLine(Calculate(-200));     // 0
Console.WriteLine(Calculate(0));        // 0
Console.WriteLine(Calculate(10_000));   // 500
Console.WriteLine(Calculate(60_000));   // 6_000
Console.WriteLine(Calculate(200_000));  // 40_000

decimal Calculate(decimal sum)
{
    return sum switch
    {
        <= 0 => 0,                  // если sum меньше или равно 0, возвращяем 0
        < 50_000 => sum * 0.05m,    // если sum меньше 50_000, возвращяем sum * 0.05m
        < 100_000 => sum * 0.1m,    // если sum меньше 100_000, возвращяем sum * 0.1m
        _ => sum * 0.2m             // в остальных случаях возвращяем sum * 0.2m
    };
}