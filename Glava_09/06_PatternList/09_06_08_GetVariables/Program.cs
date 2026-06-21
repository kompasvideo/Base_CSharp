Console.WriteLine(GetData(new[]{1,2,3}));   // First:1, Second:2, Last:3
Console.WriteLine(GetData(new[]{2,4,6,8}));   // First:2, Second:4, Last:8
Console.WriteLine(GetData(new[]{1,2}));   // Array has less than 3 elements"

string GetData(int[] variables) => variables switch
{
    [var first, var second, .., var last] => $"first: {first}, second: {second}, last: {last}",
    [..] => "Array has less than 3 elements"
};