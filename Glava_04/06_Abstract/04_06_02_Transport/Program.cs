Transport car = new Car("машина");
Transport ship = new Ship("корабль");
Transport aircraft = new Aircraft("самолёт");

car.Move();         // машина двигается
ship.Move();        // корабль двигается
aircraft.Move();    // самолёт двигается

abstract class Transport
{
    public string Name { get; }
    public Transport(string name)
    {
        Name = name;
    }
    public void Move() => Console.WriteLine($"{Name} двигается");
}

// класс корабля
class Ship : Transport
{
    public Ship(string name) : base(name) { }
}
// класс самолёты
class Aircraft : Transport
{
    public Aircraft(string name) : base(name) { }
}
class Car : Transport
{
    public Car(string name) : base(name) { }
}
