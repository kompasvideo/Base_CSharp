IAction action1 = new RunAction();
action1.Move(); // I am moving

IRunAction action2 = new RunAction();
action2.Move(); // I am running

interface IAction
{
    void Move() => Console.WriteLine("I am moving");
}
interface IRunAction : IAction
{
    // скрывает реализацию IAction
    new void Move() => Console.WriteLine("I am runing");
}
class RunAction : IRunAction { }
