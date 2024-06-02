Account acc = new Account(100);
acc.Notify += DisplayMessage;
acc.Put(20);
acc.Take(70);
acc.Take(150);

void DisplayMessage(Account sender, AccountEventArgs e)
{
    Console.WriteLine($"Сумма транзакции: {e.Sum}");
    Console.WriteLine(e.Message);
    Console.WriteLine($"Текущая сумма на счёте: {sender.Sum}");
}


class AccountEventArgs
{
    // Сообщение
    public string Message { get; }
    // Сумма, на которую изменился счёт
    public int Sum { get; }
    public AccountEventArgs(string message, int sum)
    {
        Message = message;
        Sum = sum;
    }
}

class Account
{
    public delegate void AccountHandler(Account sendler, AccountEventArgs e);
    public event AccountHandler? Notify;    
    // сумма на счётк
    public int Sum { get; private set; }
    // в конструктуре устанавливаем начальную сумму на счёте
    public Account(int sum) => Sum = sum;
    // добавление средств на счёт
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, new AccountEventArgs($"на счёт поступило: {sum}", sum));    // вызов события
    }
    // списание средств со счёта
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this, new AccountEventArgs($"Со счёта снято: {sum}", sum));    // вызов события
        }
        else
            Notify?.Invoke(this, new AccountEventArgs($"Недостаточно денег на счёте. Текущий баланс: {sum}", sum));    // вызов события
    }
}