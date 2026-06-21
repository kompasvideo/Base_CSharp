Console.WriteLine(CheckAge(200));
Console.WriteLine(CheckAge(0));
Console.WriteLine(CheckAge(17));
Console.WriteLine(CheckAge(18));

string CheckAge(int age)
{
    return age switch
    {
        <1 or >110 => "Недействительный возраст", // если age больше 110 и меньше 1
        >= 1 and < 18 => "Доступ запрещен", // если age больше и равен 1 и меньше 18
        _ => "Доступ разрешен"              // в остальных случаях
    };
}