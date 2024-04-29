//Transport transport = new Transport();
Transport car = new Car();
Transport ship = new Ship();
Transport aircraft = new Aircraft();

car.Move();
ship.Move();
aircraft.Move();

abstract class Transport
{
    public void Move()
    {
        Console.WriteLine("Транспортное средство движется");
    }
}

// класс корабля
class Ship : Transport { }
// класс самолёта
class Aircraft : Transport { }
// класс машины
class Car : Transport { }
