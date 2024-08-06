var tuple = (count: 5, sum: 10);
Console.WriteLine(tuple.count);     // 5
Console.WriteLine(tuple.sum);       // 10
Console.WriteLine();

var (name, age) = ("Tom", 23);
Console.WriteLine(name);        // Tom
Console.WriteLine(age);         // 23
Console.WriteLine();

string main = "Java";
string second = "C#";
(main, second) = (second, main);
Console.WriteLine(main);            // C#
Console.WriteLine(second);          // Java