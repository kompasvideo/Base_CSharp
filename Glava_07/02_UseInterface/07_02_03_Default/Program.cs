IMovable person = new Person();
Car car = new Car();
person.Move();  // Walking
car.Move();     // Driving

interface IMovable
{
    void Move() => Console.WriteLine("Walking");
}
class Person : IMovable {}

class Car : IMovable
{
    public void Move() => Console.WriteLine("Driving");
}