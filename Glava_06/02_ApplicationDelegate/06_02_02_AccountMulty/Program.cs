// Создаём банковский счёт
Account account = new Account(200);
// добавляем в делегат ссылку на методы
account.RegisterHandler(PrintSimpleMessage);
account.RegisterHandler(PrintColorMessage);
// Два раза подряд пытаемся снять деньги
account.Take(100);
account.Take(150);

// удаляем делегат
account.UnregisterHandler(PrintColorMessage);
// снова пытаемся снять деньги
account.Take(50);

void PrintSimpleMessage(string message) => Console.WriteLine(message);
void PrintColorMessage(string message)
{
    // устанавливаем красный цвет символов
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    // сбрасываем настройки цвета
    Console.ResetColor();
}

public delegate void AccountHandler(string messsge);
public class Account
{
    int sum;  // переменная для хранения суммы
    // создаём переменную делегата
    AccountHandler? taken;
    // регестрируем делегат
    public void RegisterHandler(AccountHandler del)
    {
        taken += del;
    }
    // отменяем регистрация делегата
    public void UnregisterHandler(AccountHandler del)
    {
        taken -= del; // удаляем делегат
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