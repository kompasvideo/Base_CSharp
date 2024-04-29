void PrintUpper(string? text)
{
    if (text != null)
    {
        Console.WriteLine(text.ToUpper());
    }
}

void PrintUpper2(string? text)
{
    if (text is null) return;
    Console.WriteLine(text.ToUpper());
}


void PrintUpper3(string? text)
{
    if (text is not null)
        Console.WriteLine(text.ToUpper());
}


void PrintUpper4(string? text)
{
    if (text is string)
        Console.WriteLine(text.ToUpper());
    else
        Console.WriteLine("NULL");
}


// null-объединение

string? text = null;
string name = text ?? "Tom"; // равно Tom если text = null
Console.WriteLine(name); // Tom


int? id = 100;
int personId = id ?? 1; // равно 100, ткак как id не равен null
Console.WriteLine(personId); // 100


string? text2 = null;
text2 ??= "Sam";
// аналогично
//text2 = text2 ?? "Sam";
Console.WriteLine(text2);

int? id2 = 100;
id2 ??= 1;
// аналогично
//id2 = id2 ?? 1;
Console.WriteLine(id); // 100
