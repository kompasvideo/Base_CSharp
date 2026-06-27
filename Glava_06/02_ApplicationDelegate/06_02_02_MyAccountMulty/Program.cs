Account account = new Account(200);
account.RegisterHandler(PrintSimpleMessage);
account.RegisterHandler(PrintColorMessage);
account.Take(100);
account.Take(150);

account.Unregisterhandler(PrintColorMessage);
account.Take(50);

void PrintSimpleMessage(string message)
{
    Console.WriteLine(message);
}
void PrintColorMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

public delegate void AccountHandler(string message);
public class Account
{
    int sum;
    AccountHandler? taken;
    public Account(int sum) => this.sum = sum;
    public void Add(int sum) => this.sum += sum;
    public void Take(int sum)
    {
        if (this.sum >= sum)
        {
            this.sum -= sum;
            taken?.Invoke($"Со счёта списано {sum} ye");
        }
        else
        {
            taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} ye");
        }
    }
    public void RegisterHandler(AccountHandler del)
    {
        taken += del;
    }
    public void Unregisterhandler(AccountHandler del)
    {
        taken -= del;
    }
}