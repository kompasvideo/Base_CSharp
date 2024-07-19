//public interface IComparer<in T>
//{
//    int Compare(T? x, T?y);
//}
var alice = new Person("Alice", 41);
var tom = new Person("Tom", 37);
var kate = new Person("Kate", 25);

Person[] people = { alice, tom, kate };
Array.Sort(people, new PeopleComparer());

foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}

class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class PeopleComparer : IComparer<Person>
{
    public int Compare(Person? p1, Person? p2)
    {
        if (p1 is null || p2 is null)
            throw new ArgumentNullException("Некорректное значение параметра");
        return p1.Name.Length - p2.Name.Length;
    }
}