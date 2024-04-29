#nullable enable

string? name = null;
PrintUpper(name);

void PrintUpper(string? text)
{
    Console.WriteLine(text?.ToUpper());
}
