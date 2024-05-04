Transport car = new Car();
Transport ship = new Ship();
Transport aircraft = new Aircraft();
car.Move();         // Корабль плывёт
ship.Move();        // Самолёт летит
aircraft.Move();    // Машина едет

abstract class Transport
{
    public abstract int Speed { get; set; }
    public abstract void Move();
}

// класс корабля
class Ship : Transport
{
    int speed;
    public override int Speed 
    {
        get => speed;
        set => speed = value; 
    }
    public override void Move()
    {
        Console.WriteLine("Корабль плывёт");
    }
}
// класс самолёты
class Aircraft : Transport
{
    int speed;
    public override int Speed
    {
        get => speed;
        set => speed = value;
    }
    public override void Move()
    {
        Console.WriteLine("Самолёт летит");
    }
}
class Car : Transport
{
    int speed;
    public override int Speed
    {
        get => speed;
        set => speed = value;
    }
    public override void Move()
    {
        Console.WriteLine("Машина едет");
    }
}
