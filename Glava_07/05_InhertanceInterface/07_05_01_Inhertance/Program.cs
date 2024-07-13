IAction action1 = new BaseAction();
action1.Move();

IRunAction action2 = new BaseAction();
action2.Move();

interface IAction
{
    void Move();
}
interface IRunAction : IAction
{
    void Run();
}
class BaseAction : IRunAction
{
    public void Move() => Console.WriteLine("Move");
    public void Run() => Console.WriteLine("Run");
}
