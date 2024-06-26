Console.WriteLine();

interface IMovable
{
    // константа
    const int minSpeed = 0; // минимальная скорость
    // статическая переменная
    static int maxSpeed = 60; // максимальная скрость
    // метод
    void Move();    // движение
    // свойство
    string Name { get; set; } //название

    delegate void MoveHandler(string message); // определение делегата для события
    // событие
    event MoveHandler MoveEvent;    // событие движения
}