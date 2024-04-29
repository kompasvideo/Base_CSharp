PrintNullable(5);
PrintNullable(null);

void PrintNullable(int? number)
{
    if(number.HasValue)
    {
        Console.WriteLine(number.Value);
        // аналогично
        Console.WriteLine(number);
    }
    else
    {
        Console.WriteLine("параметр равен null");
    }
}


int? number = null;
Console.WriteLine(number.Value);  // ошибка
Console.WriteLine(number);          // ошибок нет

Console.WriteLine(number.GetValueOrDefault());    // 0 - значение по умолчаанию для чисел
Console.WriteLine(number.GetValueOrDefault(10));  // 10

number = 15;
Console.WriteLine(number.GetValueOrDefault());   // 15
Console.WriteLine(number.GetValueOrDefault(10)); // 15

// явное преобразование от T? к T
int? x1 = null;
if(x1.HasValue)
{
    int x2 = (int)x1;
    Console.WriteLine(x2);
}


// неявное преобразование от T к T?
int x3 = 4;
int? x4 = x3;
Console.WriteLine(x4);


// неявные расшириряющие преобразования от V к T?
int x5 = 4;
long? x6 = x5;
Console.WriteLine(x6);


// явные сужающие преобразования от V к T?
long x7 = 4;
int? x8 = (int)x7;