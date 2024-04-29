Person tom = new Person();
Person tom2 = new Person { Name = "Tom", Age = 38 };

public class Person
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}