// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

interface IMovable
{
    // реализиция метода по умолчанию
    void Move() => Console.WriteLine("Walking");
    // реализация свойства по умолчанию
    // свойство только для чтения
    int MaxSpeed { get { return 0; } }
}