MixedPeople<string, int> person9 = new MixedPeople<string, int>("456", 356);
Person<string> person10 = new MixedPeople<string, int>("9867", 35678);
Console.WriteLine(person9.Id);
Console.WriteLine(person10.Id);

class Person<T>
{
    public T Id { get; }

    public Person(T id)
    {
        Id = id;
    }
}

class MixedPeople<T, K> : Person<T>
{
    public K Code { get; }

    public MixedPeople(T id, K code) : base(id)
    {
        Code = code;
    }
}