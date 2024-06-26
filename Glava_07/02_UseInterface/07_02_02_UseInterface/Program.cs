Person person = new Person();
Car car = new Car();
DoAction(person);
DoAction(car);

void DoAction(IMovable movable) => movable.Move();

// применение интерфейса в классе
class Person : IMovable
{
    public void Move()
    {
        Console.WriteLine("Человек идёт");
    }
}
// применение интерфейса в структуре
struct Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Машина едет!");
    }
}

interface IMovable
{
    void Move();
}