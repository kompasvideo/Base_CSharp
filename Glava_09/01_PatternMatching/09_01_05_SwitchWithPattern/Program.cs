Employee bob = new Manager() { IsOnVacation = true };
Employee tom = new Manager() { IsOnVacation = false };
UseEmployee(tom);           // Manager works
UseEmployee(bob);           // Object is not manager

void UseEmployee(Employee? emp)
{
    switch (emp)
    {
        case Manager manager when !manager.IsOnVacation:
            manager.Work();
            break;
        case null:
            Console.WriteLine("Object is null");
            break;
        default:
            Console.WriteLine("Object is not manager");
            break;
    }
}

class Employee
{
    public virtual void Work() => Console.WriteLine("Employee works");
}
class Manager : Employee
{
    public override void Work() => Console.WriteLine("Manager work");
    public bool IsOnVacation { get; set; }
}
