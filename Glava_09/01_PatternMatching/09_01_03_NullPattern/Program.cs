Employee? bob = new Employee();
Employee? tom = null;

UseEmployee(bob);
UseEmployee(tom);

void UseEmployee(Employee? emp)
{
    if (emp is not null)
        emp.Work();
}

class Employee
{
    public virtual void Work() => Console.WriteLine("Employee works");
}