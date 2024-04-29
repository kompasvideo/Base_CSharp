
string? name = null;

PrintUpper(name!);

void PrintUpper(string text)
{
    if (text == null) Console.WriteLine("null");
    else Console.WriteLine(text.ToUpper());
}