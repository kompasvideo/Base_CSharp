Account acc = new Account(100);
acc.Notify += DisplayMessage;
acc.Put(20);
acc.Notify -= DisplayMessage;
acc.Put(30);

void DisplayMessage(string message) => Console.WriteLine(message);

class Account
{
    public delegate void AccountHandler(string message);
    AccountHandler? notify;
    public event AccountHandler Notify
    {
        add
        {
            notify += value;
            Console.WriteLine($"{value.Method.Name} добавлен");
        }
        remove
        {
            notify -= value;
            Console.WriteLine($"{value.Method.Name} удален");
        }
    }
    // сумма на счётк
    public int Sum { get; private set; }
    // в конструктуре устанавливаем начальную сумму на счёте
    public Account(int sum) => Sum = sum;
    // добавление средств на счёт
    public void Put(int sum)
    {
        Sum += sum;
        notify?.Invoke($"на счёт поступило: {sum}");    // вызов события
    }
    // списание средств со счёта
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            notify?.Invoke($"Со счёта снято: {sum}");    // вызов события
        }
        else
            notify?.Invoke($"Недостаточно денег на счёте. Текущий баланс: {sum}");    // вызов события
    }
}