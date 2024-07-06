Account acc = new Account(100);
acc.Notify += DisplayMessage;
acc.Put(20);
acc.Put(70);
acc.Take(100);

void DisplayMessage(Account sender, AccountEventArgs e )
{
    Console.WriteLine($"Сумма транзакции: {e.Sum}");
    Console.WriteLine(e.Message);
    Console.WriteLine($"Текущая сумма на счёте: {sender.Sum}");
    Console.WriteLine();
}

class AccountEventArgs
{
    // Сообщение
    public string Message { get; }
    // Сумма на которую изменится счёт
    public int Sum { get; }
    public AccountEventArgs(string message, int sum)
    {
        Message = message;
        Sum = sum;
    }
}

class Account
{
    public delegate void AccountHandler(Account sender, AccountEventArgs e);
    public event AccountHandler? Notify;

    public int Sum { get; private set; }
    public Account(int sum) => Sum = sum;
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, 
            new AccountEventArgs($"На счёт поступило: {sum}", sum));
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this,
                new AccountEventArgs($"Сумма {sum} снята со счёта", sum));
        }
        else
        {
            Notify?.Invoke(this,
                new AccountEventArgs($"Недостаточно денег на счёте", sum));
        }
    }
}