BaseAction action1 = new BaseAction();
action1.Move(); // Move in BaseAction

IAction action2 = new HeroAction();
action2.Move(); // Move in HeroAction

HeroAction action3 = new HeroAction();
action3.Move(); // Move in HeroAction

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
    public new void Move() => Console.WriteLine("Move in HeroAction");
}
