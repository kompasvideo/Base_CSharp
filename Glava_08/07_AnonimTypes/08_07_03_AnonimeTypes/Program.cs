Person tom = new Person("Tom");
int age = 34;
var student = new {tom.Name, age};
Console.WriteLine(student.Name);
Console.WriteLine(student.age);

class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}