using Base.PersonTypes;
Base.OrganizationTypes.Company microsoft = new("Microsoft");
Person tom = new Person("Tom", microsoft);
tom.Print();

namespace Base
{
    namespace PersonTypes
    {
        class Person
        {
            string name;
            OrganizationTypes.Company company;
            public Person(string name, OrganizationTypes.Company company)
            {
                this.name = name;
                this.company = company;
            }
            public void Print()
            {
                Console.WriteLine($"Name: {name}");
                company.Print();
            }
        }
    }

    namespace OrganizationTypes
    {
        class Company
        {
            string title;
            public Company(string title) =>  this.title = title;
            public void Print() => Console.WriteLine($"Company: {title}");
        }
    }
}