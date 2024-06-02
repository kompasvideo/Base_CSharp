Account acc = new Account(100);
acc.Notify += new Account.AccountHandler(DisplayMessage);
acc.Notify += DisplayMessage;
acc.Notify += delegate (string mes)
{
    Console.WriteLine(mes);
};
acc.Notify += Console.WriteLine;
acc.Notify += messsage => Console.WriteLine(messsage);
acc.Put(20);

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