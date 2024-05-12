Person<int, string> tom = new Person<int, string>(546,"qwerty", "Tom");
Console.WriteLine(tom.Id);
Console.WriteLine(tom.Password);

class Person<T, K>
{
    public T Id { get; set; }
    public K Password { get; set; }
    public string Name { get; set; }

    public Person(T id, K password, string name)
    {
        Id = id;
        Password = password;
        Name = name;
    }
}