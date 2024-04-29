Person person = new();
// person.Name = "Bob"; // Ошибка, после инициализации изменить значение нельзя

class Person
{
    public string Name { get; init; } = "Undefened";
}