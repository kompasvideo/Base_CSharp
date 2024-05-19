try
{
    Person person = new Person { Name = "Tom", Age = 17 };
}
catch (PersonException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
    Console.WriteLine($"Некорректное значение: {ex.Value}");
}

class Person
{
    public string Name { get; set; }
    private int age;
    public int Age 
    {
        get => age;
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрация запрещена", value);
            else
                age = value;
        }
    }
}

class PersonException : ArgumentException
{
    public int Value { get; }

    public PersonException(string message, int val) : base(message)
    {
        Value = val;
    }
} 