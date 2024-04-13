Person person = new Person("Tom", 33);

(string name, int age) = person;
Console.WriteLine(name);
Console.WriteLine(age);

string name2; int age2;
person.Deconstruct(out name2, out age2);
Console.WriteLine(name2);
Console.WriteLine(age2);

(_, int age3) = person;
Console.WriteLine(age3);

class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // деконструктор
    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}
