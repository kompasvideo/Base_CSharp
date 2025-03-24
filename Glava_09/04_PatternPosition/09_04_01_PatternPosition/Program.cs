MessageDetails details = new MessageDetails { Language = "english", DateTime = "evening", 
                                              Status = "user" };
string message = GetWelcome(details);
Console.WriteLine(message); // Good evening

MessageDetails details2 = new MessageDetails
{
    Language = "english",
    DateTime = "morning",
    Status = "admin"
};
message = GetWelcome(details2);
Console.WriteLine(details2); // Hello, Admin


string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    _ => "Здасьть"
};

class MessageDetails
{
    public string Language { get; set; } = "";
    public string DateTime { get; set; } = "";
    public string Status { get; set; } = "";
    public void Deconstruct(out string lang, out string datetime, out string status)
    {
        lang = Language;
        datetime = DateTime;
        status = Status;
    }
}