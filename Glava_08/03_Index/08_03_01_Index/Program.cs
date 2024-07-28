﻿var microsoft = new Company(new[]
{
    new Person("Tom"), new Person("Bob"), new Person("Sam"), new Person("Alice")
});
// получаем объект из индексатора
Person firstPerson = microsoft[0];
Console.WriteLine(firstPerson.Name); // Tom
// Переустанавливаем объект
microsoft[0] = new Person("Mike");
Console.WriteLine(microsoft[0].Name); // Mike

class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}
class Company
{
    Person[] personal;
    public Company(Person[] people) => personal = people;
    // индексатор
    public Person this[int index]
    {
        //get => personal[index];
        //set => personal[index] = value;
        get
        {
            // если индекс имеется в массиве
            if (index >= 0 && index < personal.Length)
                return personal[index]; // то возвращяем объект Person по индексу
            else
                throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
        }
        set
        {
            // если индекс есть в массиве
            if (index >= 0  && index < personal.Length)
                personal[index] = value;    // переустанавливаем значение по индексу
        }
    }
}

