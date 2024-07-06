IMovable tom = new Person("Tom");
// подписываемся на событие
tom.MoveEvent += () => Console.WriteLine($"{tom.Name} is moving");
tom.Move();

delegate void MoveHandler();
interface IMovable
{
    protected internal void Move();
    protected internal string Name { get; }
    protected internal event MoveHandler MoveEvent;
}
class Person : IMovable
{
    string name;
    // явная реализация события - дополнительно создаётся переменная
    MoveHandler? moveEvent;
    event MoveHandler IMovable.MoveEvent
    {
        add => moveEvent += value;
        remove => moveEvent -= value;
    }
    // явная реализация свойства - в виде автосвойства
    string IMovable.Name { get => name; }
    public Person(string name) => this.name = name;
    // явная реализация метода
    void IMovable.Move()
    {
        Console.WriteLine($"{name} is walking");
        moveEvent?.Invoke();
    }
}
