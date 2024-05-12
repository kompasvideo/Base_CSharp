IntPerson<string> person7 = new IntPerson<string>(5,"r4556");
Person<int> person8 = new IntPerson<long>(7, 4587);
Console.WriteLine(person7.Id);
Console.WriteLine(person8.Id);

class Person<T>
{
    public T Id { get; }

    public Person(T id)
    {
        Id = id;
    }
}

class IntPerson<T> : Person<int>
{
    public T Code { get; set; }
    public IntPerson(int id, T code) : base(id)
    {
        Code = code;
    }
}