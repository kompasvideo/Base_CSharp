//delegate bool Predicate<in T>(T obj);

Predicate<int> isPositive = (int x) => x > 0;

Console.WriteLine(isPositive(20));
Console.WriteLine(isPositive(-20));
