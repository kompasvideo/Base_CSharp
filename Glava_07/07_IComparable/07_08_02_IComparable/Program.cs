//public interface IComparable
//{
//    int CompareTo(object? o);
//}

var tom = new Person("Tom", 37);
var bob = new Person("Bob", 41);
var sam = new Person("Sam", 25);
Person[] people = {tom, bob, sam};
Array.Sort(people);
foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}


class Person : IComparable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public int CompareTo(object? o)
    {
        if (o is Person person) return Name.CompareTo(person.Name);
        else throw new ArgumentException("Некорректное значение параметра");
    }
}
