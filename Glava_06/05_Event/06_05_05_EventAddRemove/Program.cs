Account acc = new Account(100);
acc.Notify += DisplayMessage;  // добавляем обработчик DisplayMessage
acc.Put(20);    // Добавляем на счёт 20
acc.Notify -= DisplayMessage;  // удаляем обработчик DisplayMessage
acc.Put(20);    // Добавляем на счёт 20

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
    public Account(int sum) => Sum = sum;
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        notify?.Invoke($"На счёт поступило: {sum}");
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            notify?.Invoke($"Со счёта снято: {sum}");
        }
        else
        {
            notify?.Invoke($"Недостаточно денег на счёте. Текущий баланс: {Sum}");
        }
    }
}