Console.WriteLine(CheckAge(32));
Console.WriteLine(CheckAge(33));
Console.WriteLine(CheckAge(34));

string CheckAge(int age)
{
    return age switch
    {
        not 33 => "Обычный возраст", // если age НЕ равен 33
        _ => "Вам 33 года"          // 
    };
}