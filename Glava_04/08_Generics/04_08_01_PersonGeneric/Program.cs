// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Person<T>
{
    public T Id { get; set; }
    public string Name { get; set; }
    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }
}