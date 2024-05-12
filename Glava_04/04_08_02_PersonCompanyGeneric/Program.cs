Person<int> tom = new Person<int>(546, "Tom");
Company<Person<int>> microsoft = new Company<Person<int>>(tom);

Console.WriteLine(microsoft.CEO.Id);    // 546
Console.WriteLine(microsoft.CEO.Name);  // Tom

class Company<P>
{
    public P CEO { get; set; }

    public Company(P ceo)
    {
        CEO = ceo;
    }
}

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