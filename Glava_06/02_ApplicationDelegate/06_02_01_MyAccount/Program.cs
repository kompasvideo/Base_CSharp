Account account = new Account(200);
account.RegisterHandler(PrintSimpleMessage);
account.Take(100);
account.Take(150);

void PrintSimpleMessage(string message)
{
    Console.WriteLine(message);
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
        taken = del;
    }
}