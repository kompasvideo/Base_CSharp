interface IMovable
{
    void Move();
}
abstract class Person : IMovable
{
    public abstract void Move();
}
class Driver : Person
{
    public override void Move() => Console.WriteLine("Шофёр везет машину");
}