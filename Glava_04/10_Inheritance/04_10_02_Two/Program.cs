StringPerson person4 = new StringPerson("438767");
Person<string> person5 = new Person<string>("43875");

Console.WriteLine(person4.Id);
Console.WriteLine(person5.Id);

class Person<T>
{
    public T Id { get; }

    public Person(T id)
    {
        Id = id;
    }
}

class StringPerson : Person<string>
{
    public StringPerson(string id): base(id) {}
}