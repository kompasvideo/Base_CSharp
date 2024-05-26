// Создаём банковский счёт
Account account = new Account(200);
// добавляем в делегат ссылку на метод PrintSampleMessage
account.RegisterHandler(PrintSimpleMessage);
// Два раза подряд пытаемся снять деньги
account.Take(100);
account.Take(150);

void PrintSimpleMessage(string message) => Console.WriteLine(message);


public delegate void AccountHandler(string messsge);
public class Account
{
    int sum;  // переменная для хранения суммы
    // создаём переменную делегата
    AccountHandler? taken;
    // регестрируем делегат
    public void RegisterHandler( AccountHandler del)
    {
        taken = del;
    }
    // через конструктор устанавливается начальная сумма на счёте
    public Account(int sum) => this.sum = sum;
    // добавить средства на счёт
    public void Add(int sum) => this.sum += sum;
    // взять деньги со счёта
    public void Take(int sum)
    {
        // берем деньги, если на счёте достаточно средств
        if (this.sum >= sum)
        {
            this.sum -= sum;
            taken?.Invoke($"Со счёта списано {sum} y.e.");
        }
        else
        {
            taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} y.e.");
        }
    }
}