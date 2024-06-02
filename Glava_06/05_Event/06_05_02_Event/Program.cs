Account account = new Account(100);
account.Notify += DisplayMessage;
account.Put(20);    // добавляем на счёт 20
Console.WriteLine($"Сумма на счёте: {account.Sum}");
account.Take(70);   // пытаемся снять со счёта 70
Console.WriteLine($"Сумма на счёте: {account.Sum}");
account.Take(100);  // пытаемся снять со счёта 100
Console.WriteLine($"Сумма на счёте: {account.Sum}");

void DisplayMessage(string message) => Console.WriteLine(message);

class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler Notify;
    // сумма на счётк
    public int Sum { get; private set; }
    // в конструктуре устанавливаем начальную сумму на счёте
    public Account(int sum) => Sum = sum;
    // добавление средств на счёт
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke($"на счёт поступило: {sum}");    // вызов события
    }
    // списание средств со счёта
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke($"Со счёта снято: {sum}");    // вызов события
        }
        else
            Notify?.Invoke($"Недостаточно денег на счёте. Текущий баланс: {sum}");    // вызов события
    }
}