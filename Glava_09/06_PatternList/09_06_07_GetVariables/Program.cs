int[] numbers = { 2, 3, 5 };
if (numbers is [var first, var second, .., var last])
{
    Console.WriteLine($"first: {first}, second: {second}, last: {last}");
};

