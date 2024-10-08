﻿Account account = new Account(100);
account.Put(20);    // добавляем на счёт 20
Console.WriteLine($"Сумма на счёте: {account.Sum}");
account.Take(70);   // пытаемся снять со счёта 70
Console.WriteLine($"Сумма на счёте: {account.Sum}");
account.Take(100);  // пытаемся снять со счёта 100
Console.WriteLine($"Сумма на счёте: {account.Sum}");


class Account
{
    // сумма на счётк
    public int Sum { get; private set; }
    // в конструктуре устанавливаем начальную сумму на счёте
    public Account(int sum) => Sum = sum;
    // добавление средств на счёт
    public void Put(int sum) => Sum += sum;
    // списание средств со счёта
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
        }
    }
}