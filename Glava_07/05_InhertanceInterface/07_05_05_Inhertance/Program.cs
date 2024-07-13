internal interface IAction
{
    void Move();
}
public interface IRunAction : IAction // ошибка
{
    void Run();
}
