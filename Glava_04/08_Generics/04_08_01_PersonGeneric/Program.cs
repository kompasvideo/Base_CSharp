Person<int> tom = new Person<int>(546, "Tom");  // упаковка не нужна
Person<string> bob = new Person<string>("abc123", "Bob");

int tomId = tom.Id; // распаковка не нужна
string bobId = bob.Id;

Console.WriteLine(tomId); // 546
Console.WriteLine(bobId); // abc123

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