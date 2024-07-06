Person tom = new Person("Tom");
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
    // неявная реализация события с модификатором public
    public event MoveHandler MoveEvent
    {
        add => moveEvent += value;
        remove => moveEvent -= value;
    }
    // неявная реализация свойства - в виде автосвойства, но с модификатором Public
    public string Name { get => name; }
    public Person(string name) => this.name = name;
    // неявная реализация метода, но с модификатором public
    public void Move()
    {
        Console.WriteLine($"{name} is waiting");
        moveEvent?.Invoke();
    }
}