BaseAction action1 = new HeroAction();
action1.Move(); // Move in HeroAction

IAction action2 = new HeroAction();
action2.Move(); // Move in HeroAction

interface IAction
{
    void Move();
}
class BaseAction : IAction
{
    public virtual void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroAction : BaseAction
{
    public override void Move() => Console.WriteLine("Move in HeroAction");
}
