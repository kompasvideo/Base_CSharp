Person p = new Person { name = "Tom", age = 23 };
ChangePerson(ref p);

Console.WriteLine(p.name);
Console.WriteLine(p.age);

void ChangePerson(ref Person person)
{
    person.name = "Alice";
    person = new Person { name = "Bill", age = 45 };
    Console.WriteLine(person.name);
}

class Person
{
    public string name = "";
    public int age;
}