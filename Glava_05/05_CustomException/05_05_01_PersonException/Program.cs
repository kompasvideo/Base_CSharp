try
{
    Person person = new Person { Name = "Tom", Age = 17 };

}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

class Person
{
    private int age;
    public string Name { get; set; }

    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрации запрещено");
            else
                age = value;
        }
    }
}

class PersonException : Exception
{
    public PersonException(string message) : base(message) {}
}