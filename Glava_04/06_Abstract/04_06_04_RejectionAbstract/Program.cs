Transport tesla = new Auto();
tesla.Move();       // легковая машина едет


abstract class Transport
{
    public abstract void Move();
}

abstract class Car : Transport { }

class Auto: Car
{
    public override void Move()
    {
        Console.WriteLine("легковая машина едет");
    }
}