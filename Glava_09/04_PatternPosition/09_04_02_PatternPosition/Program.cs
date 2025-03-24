MessageDetails details = new MessageDetails
{
    Language = "chinese",
    DateTime = "night",
    Status = "moderator"
};
string message = GetWelcome(details);
Console.WriteLine(message); // chenese not found, night unknown, moderator undefined


string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    (var lang, var datetime, var status) => $"{lang} not found, {datetime} unknown, {status} undefined",
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