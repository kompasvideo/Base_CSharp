int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// найдём сумму чисел больше 5
int result = Sum(integers, x => x > 5);
Console.WriteLine(result);

// найдём сумму чётных чмсел
int result2 = Sum(integers, x => x % 2 == 0);
Console.WriteLine(result2);

int Sum(int[] numbers, IsEqual func)
{
    int result = 0;
    foreach (int i in numbers)
    {
        if (func(i))
            result += 1;
    }
    return result;
}

delegate bool IsEqual(int x);