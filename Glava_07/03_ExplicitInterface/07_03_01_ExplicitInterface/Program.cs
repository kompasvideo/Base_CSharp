BaseAction baseAction1 = new BaseAction();

// baseAction1.Move(); // ! Ошибка - в BaseAction нет метода Move
// необходимо приведение к типу IAction
// небезопасное приведение
((IAction)baseAction1).Move();
// безопасное приведение
if (baseAction1 is IAction action) action.Move();
// или так
IAction baseAction2 = new BaseAction();
baseAction2.Move();


interface IAction
{
    void Move();
}
class BaseAction : IAction
{
    void IAction.Move() => Console.WriteLine("Move is Base Class");
}