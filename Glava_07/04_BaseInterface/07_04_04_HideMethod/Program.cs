BaseAction action1 = new BaseAction();
action1.Move(); // Move in BaseAction

IAction action2 = new HeroAction();
action2.Move(); // Move in BaseAction

interface IAction
{
    void Move();
}
class BaseAction : IAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroAction : BaseAction
{
    public new void Move() => Console.WriteLine("Move in HeroAction");
}
