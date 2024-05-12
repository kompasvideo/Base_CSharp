Person<int> tom = new Person<int>(546, "Tom");
Person<int>.code = 1234;

Person<string> bob = new Person<string>("abc", "Bob");
Person<string>.code = "meta";

Console.WriteLine(Person<int>.code);    // 1234
Console.WriteLine(Person<string>.code); // meta

class Person<T>
{
    public static T? code;
    public T Id { get; set; }
    public string Name { get; set; }

    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }
}