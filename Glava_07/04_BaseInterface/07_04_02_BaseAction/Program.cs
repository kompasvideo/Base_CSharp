IAction action = new HeroAction();
action.Move(); // Move in BaseAction

interface IAction
{
    void Move();
}
class BaseAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroAction : BaseAction, IAction { } 