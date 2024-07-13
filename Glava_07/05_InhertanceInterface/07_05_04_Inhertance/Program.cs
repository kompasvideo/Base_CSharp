public interface IAction
{
    void Move();
}
internal interface IRunAction : IAction
{
    void Run();
}
