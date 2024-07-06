HeroAction action1 = new HeroAction();
action1.Move();             // Move is baseAction
((IAction)action1).Move();  // Move is HeroAction

IAction action2 = new HeroAction();
action2.Move();             // Move is HeroAction

interface IAction
{
    void Move();
}
class BaseAction : IAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroAction : BaseAction, IAction
{
    void IAction.Move() => Console.WriteLine("Move in HeroAction");
}